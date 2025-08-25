namespace ContainerWithMostWater
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Execution Start!");
            int[] height = new int[] { 1, 7, 2, 5, 4, 7, 3, 6 };
            Program program = new Program();
            Console.WriteLine(program.MaxArea(height));
            Console.WriteLine("Program Execution Start!");
            Console.WriteLine("Hello, World!");
        }

        /*
        /// <summary>
        /// Time Complexity: O(n^2) Space Complexity: O(1)
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public int MaxArea(int[] heights)
        {
            int res = 0;
            for(int l =  0; l < heights.Length; l++)
            {
                for(int r = l+1; r < heights.Length; r++)
                {
                    res = Math.Max(res, (r-l) * Math.Min(heights[r], heights[l]));
                }
            }
            return res;
        }
        */

        /// <summary>
        /// Time Complexity: O(n) Space Complexity: O(1)
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public int MaxArea(int[] heights)
        {
            int res = 0;

            int left = 0, right = heights.Length - 1;

            while(left < right)
            {
                res = Math.Max(res, (right-left) * Math.Min(heights[left], heights[right]));
                if (heights[left] < heights[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return res;
        }
    }
}
