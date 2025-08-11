namespace ContainsDuplicate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Program Execution Start");
            int[] nums = new int[] {1, 2, 3, 3}; 
            Program program = new Program();
            Console.WriteLine(program.hasDuplicate(nums));
            Console.WriteLine("Program Execution End");
        }

        /*
        //Brute Force
        //Time Complexity  : O(n^2)
        //Space Complexity : O(1)
        public bool hasDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        */


        /*
        //Sorting
        //Time Complexity  : O(nlogn)
        //Space Complexity : O(1) or O(n) depending on the sorting algorithm.
        public bool hasDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
        */



        //Hash Set
        //Time Complexity  : O(n) 
        //Space Complexity : O(n)
        public bool hasDuplicate(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (int num in nums)
            {
                if (seen.Contains(num))
                {
                    return true;
                }
                seen.Add(num);
            }
            return false;
        }

        /*
        //Hash Set Length
        //Time Complexity  : O(n)  
        //Space Complexity : O(n)
        public bool hasDuplicate(int[] nums)
        {
            return new HashSet<int>(nums).Count < nums.Length;
        }
        */

    }
}
