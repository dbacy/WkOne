using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    class Method
    {
        //access modifer (public/private) - 
        //static modifer (either static or blank)
        
        //return type ( data type to expect back from method) 
        //name - make sure it's clear what it does
        //parameter list - can be zero or more, data type then parameter name 
        public static float celsuisToFahrenheit(float celsius)
        {
            float fahrenheit = 0.0f;
            fahrenheit = (celsius * (9.0f / 5.0f)) + 32;
            return fahrenheit;
        }

        public static float FahrenheitToCelsius(float fahrenheit)
        {
            float celsius = 0.0f;
                celsius = (fahrenheit -32) * (5.0f / 9.0f);
            return celsius;

        }


        static void Main(string[] args)
        {
            float temp = 17.0f;
            Console.WriteLine(celsuisToFahrenheit(temp));
            Console.WriteLine(celsuisToFahrenheit(35.0f));



        }
    }
}
