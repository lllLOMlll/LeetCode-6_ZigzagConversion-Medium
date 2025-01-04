using System.Runtime.InteropServices;
using System.Text;

public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || numRows >= s.Length)
        {
            return s;
        }

        List<StringBuilder> rows = new List<StringBuilder>();
        for (int i = 0; i < numRows; i++)
        {
            rows.Add(new StringBuilder());
        }

        int currentRow = 0;
        bool goingDown = false;

        foreach (char c in s)
        {
            rows[currentRow].Append(c);

            if (currentRow == 0 || currentRow == numRows - 1)
            {
                goingDown = !goingDown;
            }

            currentRow += goingDown ? 1 : -1;
        }

        StringBuilder result = new StringBuilder();
        foreach (StringBuilder row in rows)
        {
            result.Append(row);
        }

        return result.ToString();

    }

static void Main(string[] args)
{
    Solution s = new Solution();

    string string1 = "PAYPALISHIRING";
    int numRows1 = 3;
    Console.WriteLine("PAHNAPLSIIGYIR = " + s.Convert(string1, numRows1));

    string string2 = "PAYPALISHIRING";
    int numRows2 = 4;
    Console.WriteLine("PINALSIGYAHRPI = " + s.Convert(string2, numRows2));

    string string3 = "A";
    int numRows3 = 1;
    Console.WriteLine("A = " + s.Convert(string3, numRows3));
}
}