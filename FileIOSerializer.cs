using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace pe6
{
    internal abstract class FileIOSerializer
    {
        //------------------------------------------------serialization, save, load
        
        //перегрузка для обычного, автономного сохранения передаем название файла, оно зарезервировано в программе
        internal static void save(object saveableObj, string path) 
        {
            var binFormatter = new BinaryFormatter();
            using (var fStream = new FileStream(path, FileMode.Create))
            {
                binFormatter.Serialize(fStream, saveableObj);
            }
        }
        //перегрузка для сохранения как, сохранение с выбором типа файла и имя файла надо задавать в ручную
        internal static void save(object saveableObj, Stream fs)
        {
            var binFormatter = new BinaryFormatter();
            {
                binFormatter.Serialize(fs, saveableObj);
            }
        }
        //-----

        //перегрузка для загрузки зарезервированого файла при обычном сохранении
        internal static void load<T>(ref T loadableObj, string path) where T : class // эта конструкция предназначена для того что бы мы могли использовать как тип только классы, обекты
        {
            var binFormatter = new BinaryFormatter();
            using (var fStream = new FileStream(path, FileMode.Open))
            {
                // приведения типа с впроверкой на возможность приведения, если не возможно привести выдает NULL
                loadableObj = binFormatter.Deserialize(fStream) as T; 
            }
        }
        //перегрузка для загрузки как, с выбором загрузки файла 
        internal static void load<T>(ref T loadableObj, Stream fs) where T : class
        {

            var binFormatter = new BinaryFormatter();
            {
                loadableObj = binFormatter.Deserialize(fs) as T;
            }
        }
        //---------------------------------------------------------------------------
    }
}
