using System;

namespace DoTheMathTwo
{
    class Program
    {
        static void Main(string[] args)
        {// *,+,-,^,%,/
            int menuOption = 0;
            //int answer;
            //Console.WriteLine("Enter your equation below\nEx. 1_+_2");
            string Calculate = Console.ReadLine();
            string[] userInput = Calculate.Split(" ");
            int num1 = Convert.ToInt32(userInput[0]);
            int num2 = Convert.ToInt32(userInput[2]);


            while (menuOption != 1)
            {
                menuOption = GetNumber("1 - Exit\n2 - Add(+)\n3 - " +
                    "Sbtract(-)\n4 - Multiply(*)\n5 - " +
                    "Divide(/)\n6 - Exponent(^)\n7 -" +
                    "Remandier(%) ");
                switch (menuOption)
                {
                    case 1:
                        break;

                    case 2:
                        Calculate = GetInput("Enter equation: ");
                        int Add = (num1 + num2);
                        Add = Utils.GetNumber("What two numbers do you need the sum for: ");
                        break;

                    case 3:
                        int Subtract = (num1 - num2);
                        Subtract = Utils.GetNumber("What two numbers do your need the difference for: ");
                        break;

                    case 4:
                        int Multiply = (num1 * num2);
                        Multiply = Utils.GetNumber("What two numbers do you need multiplyed: ");
                        break;

                    case 5:
                        int Divide = (num1 / num2);
                        Divide = Utils.GetNumber("What two numbers do you need divided: ");
                        break;

                    case 6:
                        int Exponent = (num1 ^ num2);
                        Exponent = Utils.GetNumber("The exponent is: ");
                        break;

                    case 7:
                        int Remandier = (num1 % num2);
                        Remandier = Utils.GetNumber("The remandier is: ");
                        break;




                    default:
                        break;
                }
            }
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }
        public static int GetNumber(string prompt)
        {
            int answer;
            string strNumber = GetInput(prompt);
            while (!Int32.TryParse(strNumber, out answer))
            {
                Console.WriteLine("That is not an integer");
                strNumber = GetInput(prompt);
            }
            return answer;
        }
    }
}
