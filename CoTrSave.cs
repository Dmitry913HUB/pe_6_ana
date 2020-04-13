using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace pe6
{
    [Serializable()]
    internal abstract class CoTrSave
    {    
        //------------------------------------------------------------------------serialization, save, load
        internal static bool save(BindingList<CoTrigonometric> bList, string path)
        {
            try
            {
                var binFormatter = new BinaryFormatter();
                using (var fStream = new FileStream(path, FileMode.Create))
                {
                    binFormatter.Serialize(fStream, bList);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        internal static BindingList<CoTrigonometric> load(string path)
        {
            try
            {
                var binFormatter = new BinaryFormatter();
                using (var fStream = new FileStream(path, FileMode.Open))
                {
                    return binFormatter.Deserialize(fStream) as BindingList<CoTrigonometric>;
                }
            }
            catch
            {              
                return null;                
            }
        }
        //---------------------------------------------------------------------------
    }
}
