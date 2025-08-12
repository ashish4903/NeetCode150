namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Execution Start");
            Console.WriteLine("Hello, World!");
            int[] nums = new int[] { 1, 2, 7 };
            Program program = new Program();
            int[] result = program.TwoSum(nums, 9);
            // Convert array to readable string
            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine("Program Execution End");
        }


        /*
        /// <summary>
        /// Brute Force Time Complexity: O(n^2) Space Complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i +1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] {i, j};
                    }
                }
            }
            return new int[] { -1, -1 };
        }
        */


        /// <summary>
        /// Hash Map (One Pass) Time Complexity: O(n) Space Copmexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> prevMap = new Dictionary<int,int>();

            for(int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if(prevMap.ContainsKey(diff))
                {
                    return new int[] { prevMap[diff],i };
                }
                prevMap[nums[i]] = i;
            }

            return null;
        }
    }
}
