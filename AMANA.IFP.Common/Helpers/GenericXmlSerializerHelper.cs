using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace AMANA.IFP.Common.Helpers
{
    public class GenericXmlSerializerHelper
    {
        public static T DeserializeFromFile<T>(string xmlFilePath)
        {
            var filename = PathHelper.GetAbsolutePath(xmlFilePath);
            T deserialzedObject = default(T);

            if (File.Exists(filename))
            {
                using (Stream stream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T), typeof(T).GetNestedTypes());
                    try
                    {
                        deserialzedObject = (T)serializer.Deserialize(stream);                       
                    }
                    catch (Exception)
                    {
                        stream.Close();
                        throw;
                    }

                    stream.Close();
                }
            }

            return deserialzedObject;
        }

        public static void SerializeToFile<T>(string xmlFilePath, T serializableObject)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T), typeof(T).GetNestedTypes());
            
            using (Stream stream = File.Open(xmlFilePath, FileMode.Create))
            {
                serializer.Serialize(stream, serializableObject);
                stream.Close();
            }
        }
    }
}