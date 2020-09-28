using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    class Assignment8
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //  The user will enter 
                //      Y, M, or D to get the Year, Month or Day of the 
                //current date
                //      h, m, or s to get the hour, minute, or second of 
                //the current time
                string part = Utils.GetInput("What part of the date are you interested in: ");

                //  this method will take the part of the date requested
                //and from the current date return the units for that date part 
                //or time part
                int timeUnit = GetDatePart(part);


                if (timeUnit == -1)

                    break;
                    Console.WriteLine($"The time part represented by {part} is {timeUnit}");
                    
                
               





            }
        }

        private static int GetDatePart(string part)
        {
            int date = 0;
            
            if(part == "Y")
            {
                date = DateTime.Today.Year;
            }
            if (part == "M")
            {
                date = DateTime.Today.Month;
            }
            if (part == "D")
            {
                date = DateTime.Today.Day;
            }
            if (part == "h")
            {
                date = DateTime.Today.Hour;
            }
            if (part == "m")
            {
                date = DateTime.Today.Minute;
            }
            if (part == "s")
            {
                date = DateTime.Today.Second;
            }
            return date;


            

        }
       
    }
}
