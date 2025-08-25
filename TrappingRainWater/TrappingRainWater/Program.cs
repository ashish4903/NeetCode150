namespace TrappingRainWater
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[] { 0, 2, 0, 3, 1, 0, 1, 3, 2, 1 };
            Console.WriteLine("Program Execution Start");
            Program program = new Program();
            Console.WriteLine(program.Trap(height));
            Console.WriteLine("Program Execution End");
            Console.WriteLine("Hello, World!");
        }

        /*
        /// <summary>
        /// Time Complexity: O(n^2) Space Complexity: O(1)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap(int[] height)
        {
            if(height == null || height.Length == 0)
            {
                return 0;
            }

            int res = 0;

            for(int i = 0; i < height.Length; i++)
            {
                int leftMax = height[i];
                int rightMax = height[i];

                for(int j = 0; j < i; j++)
                {
                    leftMax = Math.Max(leftMax, height[j]);
                }

                for(int j = i + 1; j < height.Length; j++)
                {
                    rightMax = Math.Max(rightMax, height[j]);
                }
                res += Math.Min(leftMax, rightMax) - height[i];
            }
            return res;
        }
        */

        /// <summary>
        /// Time Complexity: O(n) Space Complexity: O(1)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap(int[] height)
        {
            if(height.Length == 0 || height == null) return 0;
            int left = 0, right = height.Length - 1;
            int leftMax = height[left], rightMax = height[right];
            int res = 0;
            while(left < right)
            {
                if(leftMax < rightMax)
                {
                    left++;
                    leftMax = Math.Max(leftMax, height[left]);
                    res += leftMax - height[left];
                }
                else
                {
                    right--;
                    rightMax = Math.Max(rightMax, height[right]);
                    res += rightMax - height[right];
                }
            }
            return res;
        }
    }
}
