using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IOStream
{
    public class FileStreams
    {
        public void WriteFile()
        {
            string path = ConfigurationManager.AppSettings["path"];

            FileStream file = new FileStream(path + "\\d.txt", FileMode.OpenOrCreate);
            Console.WriteLine("file opened");
            file.WriteByte(70);
            Console.WriteLine("data written into file");
            file.Close();
            Console.WriteLine("file closed");



        }
    }
}
