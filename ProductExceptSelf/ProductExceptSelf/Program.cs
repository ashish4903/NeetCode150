namespace ProductExceptSelf
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] nums = { 1, 2, 3 };
            Console.WriteLine(program.ProductExceptSelf(nums));
            Console.WriteLine("Hello, World!");
        }

        /*
        /// <summary>
        /// Time Complexity: O(n^2) Space Complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int product = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        product = product * nums[j];
                    }
                }
                result[i] = product;
            }
            return result;
        }
        */

        /// <summary>
        /// Time Complexity: O(n) Space Complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] res = new int[nums.Length];

            Array.Fill(res, 1);

            for(int i = 1; i < nums.Length; i++)
            {
                res[i] = res[i - 1] * nums[i - 1];
            }

            int postfix = 1;

            for(int i = nums.Length-1; i >= 0; i--)
            {
                res[i] = res[i] * postfix;
                postfix *= nums[i];
            }
            return res;
        }
    }
}
