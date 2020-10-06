using System;

namespace _00Questions
{
    class Reverse
    {
        static void Main(string[] args)
        {
            int[] nums = { 100, 17, 82, 64, 5 };
            for (int i = 0; i < nums.Length/2; i++)
            {
                int temp;
                temp = nums[i];
                nums[i] = nums[(nums.Length - 1 - i)];
                nums[nums.Length - 1 - i] = temp;
                
            } // gets me the array in reverse


            /*array.reverse(nums)
             * 
             * 
             * 
             * 
             * 
             */
        }
    }
}
