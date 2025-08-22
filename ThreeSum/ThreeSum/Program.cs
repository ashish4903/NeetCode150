namespace ThreeSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, -7 };
            Console.WriteLine("Program Execution Start");
            Program program = new Program();
            Console.WriteLine(program.ThreeSum(nums));
            Console.WriteLine("Program Execution End");
            Console.WriteLine("Hello, World!");
        }


        /*
        /// <summary>
        /// Time Complexity: O(n^3) Space Complexity: O(m) Where m is the number of triplets.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public List<List<int>> ThreeSum(int[] nums)
        {
            HashSet<Tuple<int, int, int>> uniqueTriplets = new HashSet<Tuple<int, int, int>>();

            List<List<int>> res = new List<List<int>>();

            Array.Sort(nums);


            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    for(int k = j+1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            var triplet = Tuple.Create(nums[i], nums[j], nums[k]);  
                            uniqueTriplets.Add(triplet);
                        }
                    }
                }
            }

            foreach(var  triplet in uniqueTriplets)
            {
                res.Add(new List<int> { triplet.Item1, triplet.Item2, triplet.Item3 });
            }
            return res;
        }
        */

        /// <summary>
        /// Time Complexity: O(n^2) Space Complexity: O(m) Where m is the number of triplets.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public List<List<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> res = new List<List<int>>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) break;

                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int l = i + 1, r = nums.Length - 1;

                while (l < r)
                {
                    int sum = nums[l] + nums[r] + nums[i];

                    if (sum > 0)
                    {
                        r--;
                    } else if (sum < 0)
                    {
                        l++;
                    }
                    else
                    {
                        res.Add(new List<int> { nums[l], nums[r], nums[i] });
                        l++;
                        r--;
                        while(l < r && nums[l] == nums[l-1])
                        {
                            l++;
                        }
                    }
                }
            }

            return res;
        }
    }
}
