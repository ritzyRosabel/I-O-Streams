﻿using System;
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
        public void Readfile()
        {
            string path = ConfigurationManager.AppSettings["path"];
            byte[] buf = new byte[1024];
            int c;
             FileStream file = new FileStream(path + "\\d.txt", FileMode.Open);
            Console.WriteLine("file opened");
            while (( c = file.Read(buf, 0, buf.Length)) >0)
            {
                Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));
            }
            Console.WriteLine("finished reading document");
          file.Close();
            Console.WriteLine("file closed");

        }
    }
}
