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

            FileStream file = new FileStream(path + "\\d.log", FileMode.OpenOrCreate);
            Console.WriteLine("file opened");
            file.WriteByte(120);
            file.WriteByte(70);
            Console.WriteLine("data written into file");
            file.Close();
            Console.WriteLine("file closed");
        }
        public void Readfile()
        {
            string path = ConfigurationManager.AppSettings["path"];
            int c;
            FileStream file = new FileStream(path + "\\d.log", FileMode.Open);
            long fileLength = file.Length;// gets size in byte
            byte[] buf = new byte[fileLength];
            Console.WriteLine("file opened");
            while ((c = file.Read(buf, 0, buf.Length)) > 0)
            {
                Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));
            }
            //for (int x=0; x<file.Length; x++)// when using char
            //{
            //    char r = (char)file.ReadByte();
            //    Console.WriteLine(r);

            //}
            file.Close();
            Console.WriteLine("file closed");

        }
    }
}
