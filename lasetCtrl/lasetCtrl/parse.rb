require 'nokogiri'
require 'translit'
require 'cyrillizer'


open('TagsAg.cs', 'w') { |f|

f.puts "using System;\n"

f.puts " namespace lasetCtrl {\n\n" +   "partial class Tags {\n" 
result = ""

usMap = Array.new(1000) 

files = Dir["tags/*"]


files.each do |file|
doc = Nokogiri::XML(File.open(file))

f.puts "//-----------------------------------------------------------------------------"
f.puts "//" + file
f.puts "//-----------------------------------------------------------------------------" + "\n"
doc.xpath('//PLC').each do |el|



name =  Translit.convert(el.xpath('Name').text, :english).downcase
puts name
name1 = name.gsub('(', '_').gsub(')','_').gsub('-','_').gsub(' ','')
name3 = name1.gsub /[^A-Za-z0-9]/, '_'
name3 = name3.gsub /__/, '_'
name3 = name3.gsub /_$/, ''

path = el.xpath('Path').text
type = el.xpath('Data').text
addr = el.xpath('Logical').text
addrval = addr.gsub /[^0-9\.]/,''
addrwidth = addr.gsub /[^A-Z]/ , ''
#puts name3 + "  " + path  + "  " + type + "  " + addrval + "  " + addrwidth
if name3 != ""
nameCyr = el.xpath('Name').text.encode('windows-1251', {
  :invalid => :replace,
    :undef   => :replace,
      :replace => '?'
      })

region = !!( addr =~ /M/)	  ? "M" : "X"
width = !!( addr =~ /\%.D\d/) ? "UInt32" :!!( addr =~ /\%.W\d/) ? "UInt16" : !!( addr =~ /\%.\d/) ? "Bit" : "X"
varType = type == "Real" ? "float" : type == "Int" ? "Int16" : type == "DInt" ? "Int32" : type == "Bool" ? "bool" : "nan"


addrParts = addrval.split(".")
intAdrr =  addrParts[0].to_s 
bitAddr = addrParts.count > 1 ? addrParts[1].to_s : "x"
signatura = type == "Bool" ? "#{intAdrr}, #{bitAddr}" : intAdrr
	  
getingType = type == "Real" ? "Float" : width	  
	  
f.puts "/\/\ #{nameCyr},   #{type}, #{addr}   reg = #{region}  width = #{width}"

result = "    public #{varType} get_#{name3} ()\n" \
"    { return (#{varType}) m_mem.get#{region}#{ getingType}(#{signatura}); }\n\n"
 puts result

outType = type == "Real" ? "float" : type == "Int" ? "UInt16" : type == "DInt" ? "UInt32" : type == "Bool" ? "bool" : "nan"

setter =  "    public void set_#{name3} (#{varType} val)\n" \
"    { m_mem.set#{region}#{ getingType}(#{signatura}, (#{outType}) val); }\n\n"

usMap[intAdrr.to_i] = 1
usMap[intAdrr.to_i + 1] = 1 if width == "UInt32" || width == "UInt16"
usMap[intAdrr.to_i + 2] = 1 if width == "UInt32" 
usMap[intAdrr.to_i + 3] = 1 if width == "UInt32" 

f.puts result
f.puts setter
end
end
end
f.puts "    }\n }"

for j in 0..9
val = ""
for i in 0..99
   val += usMap[j*100 + i] == 1 ? "+" : "_"
  
end
 puts val
 end
}
#File.write('tags_ag.cs', allfunctions1)
