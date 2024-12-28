public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || numRows >= s.Length)
        {
            return s;
        }


        return null;
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