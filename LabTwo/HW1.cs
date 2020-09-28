using System;
using System.Collections.Generic;
using System.Text;

namespace LabTwo
{
    class HW1
    {
        static void Main(string[] args)
        {
            int sum;
            int num1;
            int num2;
            

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number: ");
            num2 = Utils.GetNumber("Enter second number: ");
            sum = num1 + num2;
            Console.WriteLine("{1} plus {2} = {0}", sum, num1, num2);

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 - num2;
            Console.WriteLine("{1} minus {2} = {0}", sum, num1, num2);

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 * num2;
            Console.WriteLine("{1} times {2} = {0}", sum, num1, num2);

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 / num2;
            Console.WriteLine("{1} divided {2} = {0}", sum, num1, num2);




        }
    }
}
