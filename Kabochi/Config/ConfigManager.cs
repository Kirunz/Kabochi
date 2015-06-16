using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Config
{
    public class ConfigManager
    {
        
        public Config ReadConfig(string path)
        {
            System.Xml.Serialization.XmlSerializer serializer =
            new System.Xml.Serialization.XmlSerializer(typeof(Config));

            System.IO.TextReader reader = new System.IO.StreamReader(path);          
            Config conf = (Config)serializer.Deserialize(reader);
            reader.Close();
            return conf;

        }
        public void WriteConfig(Config config, string path)
        {
            System.Xml.Serialization.XmlSerializer serializer =
            new System.Xml.Serialization.XmlSerializer(typeof(Config));

            // Create an instance of the class to be serialized.

            // Writing the document requires a TextWriter.
            System.IO.TextWriter writer = new System.IO.StreamWriter(path);

            // Serialize the object, and close the TextWriter.
            serializer.Serialize(writer, config);
            writer.Close();
        }
        
    }
}
