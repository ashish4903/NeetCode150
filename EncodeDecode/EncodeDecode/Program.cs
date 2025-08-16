namespace EncodeDecode
{
    public class Program
    {
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
