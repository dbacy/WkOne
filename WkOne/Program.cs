using System;

namespace WkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str = "Derek";
            str = str.PadLeft(10, '_');
            Console.WriteLine(str);
            // makes the string 10 long 
            // _____Derek is my result
            
        }
    }
}
