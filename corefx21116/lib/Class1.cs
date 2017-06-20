using System;
using System.IO;

namespace lib
{
    public class Class1
    {
        public static FileStream OpenFile(string file)
        {
            return new FileStream(file, FileMode.Open);
        }
    }
}
