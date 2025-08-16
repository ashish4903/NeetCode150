using Microsoft.VisualBasic;

namespace EncodeDecode
{
    public class Program
    {
        /// <summary>
        /// Time Complexity: O(m) for each encode() & decode() function calls
        /// Space Complexity: O(m+n) for each encode() & decode() function calls
        /// Where m is the sum of lengths of all the strings and n is the number of strings.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            IList<string> list = new List<string>();
            list.Add("Neet");
            list.Add("Co#de");
            Program program = new Program();
            Console.WriteLine(program.Encode(list));
            Console.WriteLine(program.Decode(program.Encode(list)));
            Console.WriteLine("Hello, World!");
        }

        public string Encode(IList<string> strs)
        {
            string res = "";
            foreach (string str in strs)
            {
                res += str.Length + "#" + str;
            }
            return res;

        }

        public string Decode(string str)
        {
            List<string> res = new List<string>();

            int i = 0;

            while(i < str.Length)
            {
                int j = i;

                while (str[j] != '#')
                {
                    j++;
                }

                int length = int.Parse(str.Substring(i,j-i));

                i = j + 1;
                j= i + length;
                res.Add(str.Substring(i,length));
                i = j;
            }

            return res.ToString();

        }
    }
}
