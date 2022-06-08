using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckFileString
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255; 
            
            sbyte b = (sbyte)((sbyte)~a - 1);
           
            string fileContent = "";

            using (var streamReader = new StreamReader(args[0], Encoding.UTF8))
            {
                fileContent = streamReader.ReadToEnd();
                streamReader.Close();
            }

            if(fileContent.Contains(args[1]))
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }

            {
                GC.Collect();
            }
        }
    }
}
