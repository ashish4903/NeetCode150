using System.ComponentModel;

namespace ValidAnagram
{
    /// <summary>
    /// Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.
    ///An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Program Execution Start");
            Program program = new Program();
            string s = "racecarz";
            string t = "carracez";
            Console.WriteLine(program.IsAnagram(s, t));
            Console.WriteLine("Program Execution End");
        }

        /*
        /// <summary>
        /// Sorting Brute Force Time Complexity: O(nlogn+mlogm) & Space Complexity: O(1) or O(n+m) depending on the sorting algorithm.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }

            char[] sSort = s.ToCharArray();
            char[] tSort = t.ToCharArray();

            Array.Sort(sSort);
            Array.Sort(tSort);

            return sSort.SequenceEqual(tSort);
        }
        */

        /*
        /// <summary>
        /// Hash Map Time complexity: O(n+m) Space complexity: O(1) since we have at most 26 different characters.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> countS = new Dictionary<char, int>();
            Dictionary<char,int> countT = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
            {
                countS[s[i]] = countS.GetValueOrDefault(s[i], 0) + 1;

                countT[t[i]] = countT.GetValueOrDefault(t[i], 0) + 1;
            }

            return countS.Count == countT.Count && !countS.Except(countT).Any(); 
        }
        */


        /// <summary>
        /// Hash Table (Using Array) Time complexity: O(n+m) Space Complexity: O(1) since we have at most 26 different characters
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length) return false;

            int[] count = new int[26];

            for(int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
                count[t[i] - 'a']--;
            }

            foreach(int i in count)
            {
                if (i != 0) return false;
            }

            return true;
        }

    }
}
