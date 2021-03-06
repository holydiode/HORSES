using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HORSES
{
    public class Loger
    {
        private string _fileName = null;
        private static Loger _loger = null;
        private string _defaultName = "log.txt";
        private Loger(string file_name, bool clearOnCreation)
        {
            if (file_name is null)
            {
                file_name = _defaultName;
            }
            _fileName = file_name;



            FileInfo fileInfo = new(file_name);
            if (! fileInfo.Exists || clearOnCreation)
            {
                using (StreamWriter writer = new(this._fileName))
                {
                }
            }
        }
        public static Loger GetLoger(string file_name = null, bool clearOnCreation = true) =>
            Loger._loger ??= new(file_name, clearOnCreation);
        public void Coment(string coment)
        {
            using (StreamWriter writer = new(this._fileName, append: true))
            {
                writer.WriteLine("+++" + coment + "+++");
            }
        }
        public void Write(string msg)
        {
            using (StreamWriter writer = new(this._fileName, append: true)) {
                writer.WriteLine(DateTime.Now.ToShortTimeString() + ": " + msg);
            }
        }
    }
}
