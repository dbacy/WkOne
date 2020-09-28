using System;
using System.Collections.Generic;
using System.Text;

namespace Reputation
{
    class GDC
    {
        static void Main(string[] args)
        {
           
             static int GCD(int x, int y)

            {
                x = y = Utils.GetNumber("Enter a number: ");
                while (x != 0 && y != 0)
                {
                    if (x > y)
                        x %= y;
                    else
                        y %= x;
                }

                return x | y;
            }
        }
    }
}
