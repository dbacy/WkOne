using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace linq
{
    class unknown
    {
        static void Main(string[] args)
           
        {

            int[] randomNums = { 43, 6, 31, 84, -21, -8, 5, 6, -21, 64, 6, 43, 
                -8, -100, -8, 874, 42 };
            var average = randomNums.Average();
            Console.WriteLine(average);
            var max = randomNums.Max();
            Console.WriteLine(max);
            var min = randomNums.Min();
            Console.WriteLine(min);
            var unique = randomNums.Distinct().Count();
            Console.WriteLine(unique);
            var t = randomNums.TakeLast(3);
            Console.WriteLine();
            bool negitive = randomNums.Any(n => n < 0);
            Console.WriteLine(negitive);
            int num = Utils.GetNumber("Enter number: ");
            bool which = randomNums.All(n => n > num);
            Console.WriteLine(which);

            int small = Utils.GetNumber("Find numbers bigger than: ");
            var bigs = randomNums.Where(n => n > small);
            foreach (var n in bigs)
            {
                Console.WriteLine($"{n} is bigger than {small}");
            }

            
            var able = randomNums.Where(n => n % 7 ==0 );
            foreach (var n in able)
            {
                Console.WriteLine($"{n} is divisiable by 7. ");
            }
            int[] scores = { 21, 32, 7, 4, -2, 6, 3, -46, 6, 54, -87, 57,
                89, 57, -6, 3, 43, 6, 7, -45, 5, 24, 6 };
            //  Count the scores
                var c = scores.Count();
                Console.WriteLine(c);
            //  What is the Average and Max scores
                var average2 = scores.Average();
                Console.WriteLine(average2);
                var max1 = scores.Max();
                Console.WriteLine(max1);
            //  How many Distinct scores are there
                var dist = scores.Distinct().Count();
                Console.WriteLine(dist);
            //  add up the Distinct scores
                var distPlus = scores.Distinct().Sum();
                Console.WriteLine(distPlus);
            //  add up all numbers greater than 44
                var greater = scores.Where(n => n > 44).Sum();
                Console.WriteLine(greater);
            //  what is the average of numbers less than 0
                var less = scores.Where(n => n < 0).Average();
                Console.WriteLine(less);
            //  how many numbers are between -20 and 30
                var c2 = scores.Where(n => n >= -20 && n <= 30).Count();
                Console.WriteLine(c2);


            string[] animals = { "moose", "ferret", "gnu", "ant", 
                "cow", "emu", "deer", "hippo", "bear", "jackalop", "lama" };
            //  how many animals are longer than 4
                var list = animals.Where(a => a.Length > 4).Count();
                Console.WriteLine(list);
            //  find animals that end with 'u'. use your method to print them
                var endWithU = animals.Where(a => a.EndsWith("U"));
                printList(endWithU);
            //  order the animals alphabetically and print
                var alphabetically = animals.OrderBy(n => n);
                printList(alphabetically);
            //  what is the longest name
                var longest = animals.OrderByDescending(s => s.Length).First();
                Console.WriteLine(longest);
        }
        private static void printList(IEnumerable<object> list)
        {
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}
