using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCardConsoleApp
{
    public static class TestX
    {
        static int[,] array = new int[,] { { 1, 1,1,1,5 }, { 2, 2,2,2,2 }, { 8, 8,8,8,8 }, { 9, 4,9,9,9 } };
        //static int[,,] array = new int[,,]
        //{ { { 1, 1 }, { 2, 2 }, { 3, 3 } }, { { 4, 4 }, { 5, 5 }, { 6, 6 } } };




        


        public static void Main()
        {
            //var nums = Enumerable.Range(0, 8).ToArray();
            string[] nums = new string[9]
                {
                "-","A","B","C","D","E","F","G","H"
                };
        var rnd = new Random();

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }


            // Shuffle the array
            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = rnd.Next(nums.Length);
                string temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;

            }
                foreach (var num in nums)
            {
                Console.WriteLine(num); 
            }
            
            


        }
    }
}
