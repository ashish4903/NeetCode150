using System.Globalization;

namespace TwoSumII
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program prograam = new Program();
            Console.WriteLine("Program Execution Start");
            int[] nums = new int[] { 1, 2, 4, 4 };
            Console.WriteLine(prograam.TwoSum(nums, 8));
            Console.WriteLine("Program Execution End");
            Console.WriteLine("Hello, World!");
        }

        /*
        /// <summary>
        /// Time Complexity: O(n^2) Space Complexity: O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        return new int[] { i + 1, j + 1 };

                    }
                }
            }
            return new int[0];
        }
        */

        /// <summary>
        /// Time Complexity: O(n) Space Complexity: O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            int l = 0, r = numbers.Length - 1;
            while (l < r)
            {
                if (numbers[l] + numbers[r] > target)
                {
                    r--;
                }
                else if (numbers[l] + numbers[r] < target)
                {
                     l++;
                }
                else
                {
                    return new int[] { l+1, r+1 };
                }
            }

            return new int[0];
        }
    }
}
