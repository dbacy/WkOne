using System;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Card myCard = new Card("Q", "♠", 14);
            Console.WriteLine(myCard.Suit);
            myCard.Value = 10;
            Console.ReadLine();



        }
    }
}
