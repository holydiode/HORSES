using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HORSES
{
    class Loger
    {
        private string _file_name = null;
        private static Loger _loger = null;
        private string default_name = "log.txt";
        private Loger(string file_name, bool clearOnCreation)
        {
            if (file_name is null)
            {
                file_name = default_name;
            }
            _file_name = file_name;



            FileInfo fileInfo = new FileInfo(file_name);
            if (! fileInfo.Exists || clearOnCreation)
            {
                using (StreamWriter writer = new StreamWriter(this._file_name))
                {
                }
            }
        }
        public static Loger GetLoger(string file_name = null, bool clearOnCreation = true)
        {
            if (Loger._loger is null)
            {
                Loger._loger = new Loger(file_name, clearOnCreation);
            }

            return Loger._loger;
            
        }

        public void Coment(string coment)
        {
            using (StreamWriter writer = new StreamWriter(this._file_name, append: true))
            {
                writer.WriteLine("+++" + coment + "+++");
            }
        }

        public void Write(string msg)
        {
            using (StreamWriter writer = new StreamWriter(this._file_name, append: true)) {
                writer.WriteLine(DateTime.Now.ToShortTimeString() + ": " + msg);
            }
        }
    }
}
