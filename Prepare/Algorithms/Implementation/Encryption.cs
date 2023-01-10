using System.Text;
using System.Text.RegularExpressions;

namespace HackerRank.Prepare.Algorithms.Implementation;
//https://www.hackerrank.com/challenges/encryption/problem
internal class Encryption
{
    public static string encryption(string s)
    {
        string text = Regex.Replace(s, " ", "");
        var sqrt = Math.Sqrt(text.Length);
        var rows = (int)Math.Floor(sqrt);
        var columns = (int)Math.Ceiling(sqrt);
        if (rows * columns < text.Length) rows = columns;
        var grid = new char[rows, columns];
        for (int i = 0; i < text.Length; i++)
        {
            var row = i / columns;
            var column = i % columns;
            grid[row, column] = text[i];
        }
        var sb = new StringBuilder();
        for (int col = 0; col < grid.GetLength(1); col++)
        {
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                var val = grid[row, col];
                bool hasChar = val != default;
                if (hasChar)
                {
                    sb.Append(val);
                }
            }

            bool isLastCol = (col + 1) / grid.GetLength(1) == 1;
            if (!isLastCol) sb.Append(' ');
        }
        return sb.ToString();
    }
}
