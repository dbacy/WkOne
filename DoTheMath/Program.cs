using System;

namespace DoTheMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your equation below\nEx. 1_+_2");
            string Calculate = Console.ReadLine();
            string[] userInput = Calculate.Split(" ");
            
            int num1 = Convert.ToInt32(userInput[0]);
            int num2 = Convert.ToInt32(userInput[2]);



          
               

                    
                        if (userInput[1] == "+")
                            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + (num1 + num2));
                        

                    
                        if (userInput[1] == "-")
                            Console.WriteLine("The subtraction of " + num1 + " and " + num2 + " is: " + (num1 - num2));
                       

                    
                        if (userInput[1] == "*")
                            Console.WriteLine("The muliplication of " + num1 + " and " + num2 + " is: " + (num1 * num2));
                        

                   
                        if (userInput[1] == "/")
                            Console.WriteLine("The division of " + num1 + " and " + num2 + " is: " + (num1 / num2));
                       

                    
                        if (userInput[1] == "^")
                            Console.WriteLine("The exponent of " + num1 + " and " + num2 + " is: " + Math.Pow(num1, num2));
                        

                    
                        if (userInput[1] == "%")
                            Console.WriteLine("The remainder of " + num1 + " and " + num2 + " is: " + (num1 % num2));
                        

        }
    }
}
