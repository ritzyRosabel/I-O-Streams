﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IOStream
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileStreams file = new FileStreams();
            //file.WriteFile();

            //file opened
            //data written into file
            //file closed
            //d.txt = f

            //file.Readfile();
            //file opened
            // 70
            //finished reading document
            //file closed

            // StreamWriters writers = new StreamWriters();
            //writers.WriteToFile();
            // This Code was written by Rosabel to learn Stream Writer class

            StreamReaders readers = new StreamReaders();
            readers.ReadFile();
            //filestream created
            //streamreader created
            //reading file
            // This Code was written by Rosabel to learn Stream Writer class
            //This Code was written by Rosabel to learn Stream Writer class

            //stream reader closed
            //filestream closed
            Cosnsole.ReadLine();
            // worked as soon as i removed all instance of filestream. apparently you cant have two streams accessing a file at the same time
            //F
            // finished reading document
            //file closed
            //same result

        }
    }
}
