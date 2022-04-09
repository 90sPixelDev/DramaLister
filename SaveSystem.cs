using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DramaLister
{
    class SaveSystem
    {
        BinaryFormatter bf = new BinaryFormatter();

        public void Save(DramaSheet dramaSheet, string saveFilePath)
        {
            FileStream file = File.Open(saveFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            bf.Serialize(file, dramaSheet);
            file.Close();
        }
        public static object Load(string fileName)
        {
            Stream loadedDramaSheet = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter BinFor = new BinaryFormatter();

            object ds = BinFor.Deserialize(loadedDramaSheet);
            loadedDramaSheet.Close();
            return ds;
        }

    }
}
