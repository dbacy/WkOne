using System;

namespace ClassDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            // t, mc, g, l 
            Movie myMovie = new Movie("Ruthless", "Action", 
                "Denziel Washington",108);
            Console.WriteLine(myMovie);
        }
    }
}
