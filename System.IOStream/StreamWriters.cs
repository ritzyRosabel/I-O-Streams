using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IOStream
{
    public class StreamWriters
    {
        public void WriteToFile()
        {
            string path = ConfigurationManager.AppSettings["path"];
            FileStream file = new FileStream(path +"\\e.txt",FileMode.OpenOrCreate);
            Console.WriteLine("file opened");

            StreamWriter stream = new StreamWriter(file);
            stream.Write(" This Code was written by Rosabel");
            stream.WriteLine(" to learn Stream Writer class");
            Console.WriteLine("written to file");
            stream.Close();
            Console.WriteLine("closed StreamWriter");
            file.Close();
            Console.WriteLine("closed FileStream");

        }
    }
}
