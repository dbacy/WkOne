using System;

namespace Reputation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int nLargest;
            int nSmallest;
            int nCurrent;
            string strEntry = "";

            nLargest = nSmallest = Utils.GetNumber("Enter an integer: ");

            while (strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);

                
                if (nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
                else if (nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }

                strEntry = Utils.GetInput("Enter another integer or Q to Quit: ");
            }

          


            Console.WriteLine("The largest value you entered was: " + nLargest + ".");
            Console.WriteLine("The smallest value you entered was: " + nSmallest + ".");

        }
    }
}
