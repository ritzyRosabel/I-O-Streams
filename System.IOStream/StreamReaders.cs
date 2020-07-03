using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IOStream
{
    public class StreamReaders
    {
        public void ReadFile()
        {
            string path = ConfigurationManager.AppSettings["path"];
            FileStream file = new FileStream(path + "\\e.txt", FileMode.OpenOrCreate);
            Console.WriteLine("filestream created");
            StreamReader stream = new StreamReader(file);
            Console.WriteLine("streamreader created");
            Console.WriteLine("reading file");
            stream.ReadToEnd();
            stream.Close();
            Console.WriteLine("stream reader closed");
            file.Close();
            Console.WriteLine("filestream closed");
        }
    }
}
