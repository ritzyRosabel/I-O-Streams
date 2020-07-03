using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IOStream
{
    public class TextWriters
    {
        public void WriteFile()
        {
            string path = ConfigurationManager.AppSettings["path"];

            TextWriter writer = File.CreateText(path);//Textwriter is an abstract class
            writer.Write("wan ti mu hushpuppi, gucci gucci, ");
            writer.WriteLine("yahoo boy don turn small puppy,");
            writer.Write("wan ti mu Oga yin,you are still pressing");
            writer.Write("ok i wont talk, i am watching");
            writer.WriteLine(" i swear they will catch you");
            writer.WriteLine("they will  catch you");

        }
    }
}
