using System;
using System.Collections.Generic;
using System.Text;

namespace Reputation
{
    class Guess
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int hidden;
            int guess;


            while (true)
            {
                hidden = rand.Next(100);
                 Console.WriteLine(hidden);

                guess = Utils.GetNumber("Enter your guess: ");
                while (guess != hidden)
                {




                    if (guess < hidden)
                    {
                        Console.WriteLine("Your guess was low , try again");
                    }
                    if (guess > hidden)
                    {
                        Console.WriteLine("Your guess was to high , try again");
                    }
                    if (guess == hidden)
                    {
                        Console.WriteLine("You are a winner!");
                    }
                }  
            }
            
            Console.WriteLine("Play Again (Y/N): ");
            string responce = Console.ReadLine();
            if (responce != "Y")
            {
                //break;
            }
        }
    }
}
