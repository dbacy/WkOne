using System;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            string strPlayerName;
            double dblHits, dlbAtBats;
            double dblBattingAverage;
            Console.WriteLine("This program calculates a baseball player's batter average");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter player's name: ");
            strPlayerName = Console.ReadLine();                 
            
            Console.Write("Enter the player's # of hits: ");
            dblHits = Convert.ToInt32(Console.ReadLine());    
            
            Console.Write("Enter the player's # of at bats: ");
            dlbAtBats = Convert.ToInt32(Console.ReadLine());

            dblBattingAverage = dblHits / dlbAtBats;
            Console.WriteLine($"{strPlayerName}'s batting average is {dblBattingAverage}");



        }
    }
}
