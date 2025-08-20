namespace LongestConsecutiveSequence
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Execution Start");
            Program program = new Program();
            int[] nums = { 1, 1, 2, 3, 4, 5, 6, 0, 12, 56 };
            Console.WriteLine(program.LongestConsecutive(nums));
            Console.WriteLine("Program Execution End");
            Console.WriteLine("Hello, World!");
        }

        /*
        /// <summary>
        /// Time Complexity: O(n^2) Space Complexity: O(n) 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestConsecutive(int[] nums)
        {
            int res = 0;
            HashSet<int> set = new HashSet<int>(nums);
            foreach(int num in nums)
            {
                int streak = 0, curr = num;

                while (set.Contains(curr))
                {
                    streak++;
                    curr++;
                }
                res = Math.Max(res, streak);
            }
            return res;
        }
        */

        /// <summary>
        /// Time Complexity: O(n) Space Complexity: O(n) 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);

            int longest = 0;

            foreach (int num in set)
            {
                if(!set.Contains(num-1))
                {
                    int length = 1;
                    while(set.Contains(num+length))
                    {
                        length++;
                    }
                    longest = Math.Max(longest, length);
                }
            }
            return longest;
        }
    }
}
