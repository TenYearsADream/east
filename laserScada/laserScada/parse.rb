require 'nokogiri'
require 'translit'
require 'cyrillizer'


open('TagsAg.cs', 'w') { |f|

f.puts "using System;\n"
f.puts "using log4netSample.Logging;\n"
f.puts " namespace laserScada {\n\n" +   "partial class Tags {\n" 
result = ""

globalTagNames = Array.new

usMap = Array.new(1000) 

files = Dir["tags/*"]


files.each do |file|
doc = Nokogiri::XML(File.open(file))

localTagNames = Array.new 



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
type = el.xpath('Data_Type').text
addr = el.xpath('Logical_Address').text
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
"    { m_mem.set#{region}#{ getingType}(#{signatura}, (#{outType}) val); \n"\
"      Log.Write(LogLevel.Info, \"set #{name3} to \" + val.ToString());}\n\n"

stringSetter =  "    public bool sets_#{name3} ( string str) {\n"\
"    #{varType} val;\n"\
"    if (!#{varType}.TryParse(str, out val)){\n"\
"        System.Windows.MessageBox.Show(\"Failed on try parse \" + str + \" as #{varType} \");\n"\
"        return false; }\n"\
"    set_#{name3} (val);\n"\
"    return true;}\n\n"
stringGetter = "    public string gets_#{name3} () { \n"\
"    return get_#{name3}().ToString();}\n\n"

getterName = "    public string debug_name_#{name3} () { \n"\
"    return \"#{nameCyr}\";}\n\n"

usMap[intAdrr.to_i] = 1
usMap[intAdrr.to_i + 1] = 1 if width == "UInt32" || width == "UInt16"
usMap[intAdrr.to_i + 2] = 1 if width == "UInt32" 
usMap[intAdrr.to_i + 3] = 1 if width == "UInt32" 

localTagNames << "#{name3}"

#fileEnum += name3 + ",\n"

f.puts result
f.puts setter
f.puts stringSetter
f.puts stringGetter
f.puts getterName
end
end

#generate file enums
extn = File.extname  file        
namef = File.basename file, extn  
fileEnum  = "public enum local_" + namef + "{\n"
localTagNames.each do |tagname|
fileEnum += tagname.to_s + ",\n"
end
fileEnum += "};\n\n"

localTagNames.map do |e| globalTagNames << e.dup end

#generate switch getter






f.puts fileEnum
end

#generate global files enums
globalFileEnum  = "public enum gTags" +  "{\n"
globalTagNames.each do |tagname|
globalFileEnum += tagname.to_s + ",\n"
end
globalFileEnum += "};\n\n"

f.puts globalFileEnum

switchGetter = "    public string get_by_name(string str) {\n"\
"    switch (str){"

globalTagNames.each do |tagname|
switchGetter += "case \"#{tagname}\":\n" \
"   return gets_#{tagname}();\n"

end
switchGetter += "default: \n" \
"   return \"NAN\";\n" \
"} \n }"


f.puts switchGetter

switchGetter = "    public bool set_by_name(string str, string val) {\n"\
"    switch (str){"

globalTagNames.each do |tagname|
switchGetter += "case \"#{tagname}\":\n" \
"   return sets_#{tagname}(val);\n"

end
switchGetter += "default: \n" \
"   return false;\n" \
"} \n }"

f.puts switchGetter


#debug name getter
switchGetter = "    public string get_debug_by_name(string str) {\n"\
"    switch (str){"

globalTagNames.each do |tagname|
switchGetter += "case \"#{tagname}\":\n" \
"   return debug_name_#{tagname}();\n"

end
switchGetter += "default: \n" \
"   return \"NAN\";\n" \
"} \n }"


f.puts switchGetter
f.puts "    }\n }"

for j in 0..9
val = ""
for i in 0..99
   val += usMap[j*100 + i] == 1 ? "+" : "_"
  
end
 f.puts "//" +  val
 end
}
#File.write('tags_ag.cs', allfunctions1)
