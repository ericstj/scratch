using lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader(Class1.OpenFile("data.txt")))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }
        }
    }
}
