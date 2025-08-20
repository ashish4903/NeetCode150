namespace PalindromeString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Execution Start");
            Program program = new Program();
            string str = "aca";
            Console.WriteLine(program.IsPalindrome(str));
            Console.WriteLine("Program Execution End");
            Console.WriteLine("Hello, World!");
        }

        /*
        /// <summary>
        /// Time Complexity: O(n) Space Complexity: O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrome(string s)
        {
            string newStr = "";
            foreach (char c in s)
            {
                if(char.IsLetterOrDigit(c))
                {
                    newStr += char.ToLower(c);
                }
            }

            return newStr == new string(newStr.Reverse().ToArray());
        }
        */

        /// <summary>+
        /// Time Complexity: O(n) Space Complexity: O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrome(string s)
        {
            int leftPtr = 0;
            int rightPtr = s.Length - 1;

            while (leftPtr < rightPtr)
            {
                while(leftPtr < rightPtr && !AlphaNum(s[leftPtr]))
                {
                    leftPtr++;
                }

                while(rightPtr >  leftPtr && !AlphaNum(s[rightPtr]))
                {
                    rightPtr--;
                }

                if (char.ToLower(s[leftPtr]) != char.ToLower(s[rightPtr]))
                {
                    return false;
                }
                leftPtr++; rightPtr--;
            }
            return true;
        }

        public bool AlphaNum(char c )
        {
            return (c >= '0' && c <= '9' ||
                c >= 'a' && c <= 'z' ||
                c >= 'A' && c <= 'Z');
        }
    }
}
