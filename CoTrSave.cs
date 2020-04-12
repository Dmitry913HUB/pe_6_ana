using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace pe6
{
    [Serializable()]
    internal class CoTrSave
    {

        BindingList<CoTrigonometric> bList = new BindingList<CoTrigonometric>();

        internal CoTrSave(BindingList<CoTrigonometric> bl)
        {
            this.bList = bl;
        }
        internal CoTrSave()
        {
            this.bList = null;
        }
        //--------------------------------------------------------------------
        internal BindingList<CoTrigonometric> ReadAndDeserialize(string path)
        {
            var serializer = new XmlSerializer(typeof(BindingList<CoTrigonometric>));
            using (var reader = new StreamReader(path))
            {
                return (BindingList<CoTrigonometric>)serializer.Deserialize(reader);
            }

        }

        internal void SerializeAndSave(string path, BindingList<CoTrigonometric> data)
        {
            var serializer = new XmlSerializer(typeof(BindingList<CoTrigonometric>));
            using (var writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, data);
                writer.Flush();//???
            }

        }
        internal void save()//BindingList<CoTrigonometric> bList
        {
            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream("test.bin", FileMode.Create))
            {
                binFormatter.Serialize(file, bList);
            }
        }
        internal BindingList<CoTrigonometric> load()//BindingList<CoTrigonometric> bList
        {
            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream("test.bin", FileMode.Open))
            {
                //var neww = binFormatter.Deserialize(file) as BindingList<CoTrigonometric>;
                return binFormatter.Deserialize(file) as BindingList<CoTrigonometric>;

            }
        }
        //----------------------------------------------------------------
    }
}
