namespace GroupAnagrams
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Program Execution Start");
            Program program = new Program();
            string[] strs = new string[] { "act","pots","tops","cat","stop","hat" };
            Console.Write(program.GroupAnagrams(strs));
            Console.WriteLine("Program Execution End");
        }

        /*
        /// <summary>
        /// Sorting Time Complexity: O(m*nlogn) Space Complexity: O(m*n) Where m is the number of strings and n is the length of the longest string.
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                char[] chars = str.ToCharArray();

                Array.Sort(chars);

                string sortedS = new string(chars);

                if(!res.ContainsKey(sortedS))
                {
                    res[sortedS] = new List<string>();
                }
                res[sortedS].Add(str);
            }
            return res.Values.ToList<List<string>>();
        }
        */


        /// <summary>
        /// Hash Table Time Complexity: O(m*n) Space Complexity: O(m*n) Where m is the number of strings and n is the length of the longest string.
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();

            foreach(var str in strs)
            {
                int[] count = new int[26];

                foreach (char c in str)
                {
                    count[c-'a']++;
                }

                string key = string.Join(",", count);

                if (!res.ContainsKey(key))
                {
                    res[key] = new List<string>();
                }
                res[key].Add(str);
            }

            return res.Values.ToList<List<string>>();
        }
    }
}
