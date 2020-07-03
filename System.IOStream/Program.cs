using System;
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
            FileStreams file = new FileStreams();
            file.WriteFile();

            //file opened
            //data written into file
            //file closed
            //d.txt = f

            file.Readfile();
            Console.ReadLine();
        }
    }
}
