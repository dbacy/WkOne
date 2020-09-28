using System;
using System.Collections.Generic;
using System.Text;

namespace LabTwo
{
    class HW2
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            num1 = Utils.GetNumber("Enter first number: ");
            num2 = Utils.GetNumber("Enter second number: ");
            num3 = Utils.GetNumber("Enter third number: ");

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Largest number is {num1}");
            }
             if(num1 < num2 && num1 < num3)
            {
                Console.WriteLine($"Smallest number is {num1}");
            }
             if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine($"Smallest number is {num2}");
            }
             if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"Largest number is {num2}");
            }
             if (num3 < num1 && num3 < num2)
            {
                Console.WriteLine($"Smallest number is {num3}");
            }
             if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"Largest number is {num3}");
            }


        }
    }
}
