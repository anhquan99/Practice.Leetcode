using System.Text;

namespace Application;
public partial class StringSolution
{
    public string DigitSum(string s, int k)
    {
        if (s.Length <= k) return s;
        var i = 0;
        var sb = new StringBuilder();
        while (i < s.Length)
        {
            var nextIndex = i + k > s.Length ? s.Length - i : k;
            var valStr = s.Substring(i, nextIndex);
            i += nextIndex;
            var val = 0;
            foreach (char c in valStr)
            {
                val += int.Parse(c.ToString());
            }
            sb.Append(val);
        }
        return DigitSum(sb.ToString(), k);
    }
}