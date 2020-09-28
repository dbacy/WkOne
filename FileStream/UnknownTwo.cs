using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FS
{
    class UnknownTwo
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamWriter textFile = new StreamWriter(fs);
            textFile.Write("This is a test ");
            textFile.close();




        }

    }
}
