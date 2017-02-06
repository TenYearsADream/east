require 'nokogiri'
require 'translit'
require 'cyrillizer'


open('TagsAg.cs', 'w') { |f|

f.puts "using System;\n"

f.puts " namespace lasetCtrl {\n\n" +   "partial class Tags {\n" 
result = ""

doc = Nokogiri::XML(File.open("tags/am.xml"))


doc.xpath('//PLC').each do |el|


name =  Translit.convert(el.xpath('Name').text, :english).downcase
name1 = name.gsub('(', '_').gsub(')','_').gsub('-','').gsub(' ','')
name3 = name1.gsub /[^A-Za-z0-9]/, '_'


path = el.xpath('Path').text
type = el.xpath('Data').text
addr = el.xpath('Logical').text
addrval = addr.gsub /[^0-9]/,''
addrwidth = addr.gsub /[^A-Z]/ , ''
puts name3 + "  " + path  + "  " + type + "  " + addrval + "  " + addrwidth
if name3 != ""
nameCyr = el.xpath('Name').text.encode('windows-1251', {
  :invalid => :replace,
    :undef   => :replace,
      :replace => '?'
      })

f.puts "/\/\ #{nameCyr},   #{type}, #{addr}  "
result = "    public #{type == "Real" ? "float" : type == "Int" ? "Int16" : type == "DInt" ? "Int64" : "nan" } get_#{name3} ()\n" \
"    { return (#{type == "Real" ? "float" : type == "Int" ? "Int16" : type == "DInt" ? "Int64" : "nan" }) m_plc.get#{path == "AM" ? "M": "X"}#{ type == "Int" ? "Word": type == "DInt" ? "DWord" : type == "Real" ? "Real" : "X"}(#{addrval}); }\n\n"
 puts result

f.puts result
end
end

f.puts "    }\n }"

}
#File.write('tags_ag.cs', allfunctions1)
