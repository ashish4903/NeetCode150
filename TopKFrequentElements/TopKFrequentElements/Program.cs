namespace TopKFrequentElements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] nums = new int[] { 1, 2, 3, 4, 4, 2, 2, 2 };
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Program Execution Start");
            Console.WriteLine(program.TopKFrequent(nums, 2));
            Console.WriteLine("Program Execution End");
        }

        /*
        /// <summary>
        /// Sorting Time Complexity: O(nlogn) Space Complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] TopKFrequent(int[] nums, int k)
        {
            var count = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (count.ContainsKey(i))
                {
                    count[i]++;
                }

                else
                {
                    count[i] = 1;
                }
            }

            List<int[]> arr = count.Select(entry => new int[] { entry.Value, entry.Key }).ToList();

            arr.Sort((a, b) => b[0].CompareTo(a[0]));

            int[] res = new int[k];

            for(int i = 0; i < k; i++)
            {
                res[i] = arr[i][1];
            }

            return res;
        }
        */

        /// <summary>
        /// Min Heap Time Complexity: O(nlogk) Space Complexity: O(n+k)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] TopKFrequent(int[] nums, int k)
        {
            var count = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (count.ContainsKey(i))
                {
                    count[i]++;
                }
                else
                {
                    count[i] = 1;
                }
            }

            var heap = new PriorityQueue<int, int>();

            foreach (var entry in count)
            {
                heap.Enqueue(entry.Key, entry.Value);

                if (heap.Count > k)
                {
                    heap.Dequeue();
                }
            }

            int[] res = new int[k];

            for (int i = 0; i < k; i++)
            {
                res[i] = heap.Dequeue();
            }

            return res;
        }
    }
}
