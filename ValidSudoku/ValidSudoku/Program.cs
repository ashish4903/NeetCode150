namespace ValidSudoku
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            char[][] chars = new char[][]
{
    new char[] { '1','2','.','.','3','.','.','.','.' },
    new char[] { '4','.','.','5','.','.','.','.','.' },
    new char[] { '.','9','8','.','.','.','.','.','3' },
    new char[] { '5','.','.','.','6','.','.','.','4' },
    new char[] { '.','.','.','8','.','3','.','.','5' },
    new char[] { '7','.','.','.','2','.','.','.','6' },
    new char[] { '.','.','.','.','.','.','2','.','.' },
    new char[] { '.','.','.','4','1','9','.','.','8' },
    new char[] { '.','.','.','.','8','.','.','7','9' }
};
            Console.WriteLine("Program Execution Start");
            Console.WriteLine(program.IsValidSudoku(chars));
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Program Execution End");
        }

        /// <summary>
        /// Time Complexity:On^2) Space Complexity: O(n^2)
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
            Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
            Dictionary<string, HashSet<char>> squares = new Dictionary<string, HashSet<char>>();

            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    if (board[r][c] == '.') continue;

                    string squarekey = (r / 3) + "," + (c / 3);

                    if ((rows.ContainsKey(r) && rows[r].Contains(board[r][c])) ||
                        (cols.ContainsKey(c) && cols[c].Contains(board[r][c])) ||
                        (squares.ContainsKey(squarekey) && squares[squarekey].Contains(board[r][c])))
                    {
                        return false;
                    }

                    if (!rows.ContainsKey(r)) rows[r] = new HashSet<char>();

                    if (!cols.ContainsKey(c)) cols[c] = new HashSet<char>();

                    if (!squares.ContainsKey(squarekey)) squares[squarekey] = new HashSet<char>();

                    rows[r].Add(board[r][c]);

                    cols[c].Add(board[r][c]);

                    squares[squarekey].Add(board[r][c]);
                }
            }
            return true;
        }
    }
}
