using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IOStream
{
    public class TextReaders
    {
        public void ReadFile()
        {
            string path = ConfigurationManager.AppSettings["path"];
            TextReader reader = File.OpenText(path+"\\r.txt");
            Console.WriteLine("file open");
            Console.WriteLine("reading file");
            string data = reader.ReadToEnd();
            Console.WriteLine(data);
            reader.Close();
        }
    }
}
