using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Bof.Stat.DCS.Converter.Common
{
    public class Serialization
    {
        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding { get { return Encoding.UTF8; } }
        }

        public static T DeserializeFromFile<T>(string filename)
        {
            T obj = default(T);

            using (var stream = new FileStream(filename, FileMode.Open))
            {
                obj = Deserialize<T>(stream);
            }

            return obj;
        }

        public static T Deserialize<T>(Stream stream)
        {
            T obj = default(T);
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (var reader = XmlReader.Create(stream))
            {
                obj = (T)serializer.Deserialize(reader);
            }

            return obj;
        }

        public static string Serialize<T>(T source) where T : notnull
        {
            XmlSerializer xmlSerializer = new XmlSerializer(source.GetType());

            using (StringWriter textWriter = new Utf8StringWriter())
            {
                xmlSerializer.Serialize(textWriter, source);

                return textWriter.ToString();
            }
        }
    }
}
