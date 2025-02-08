using System.Text;

namespace Application;
public partial class StringSolution
{
    public string GcdOfStrings(string str1, string str2)
    {
        var longStr = str1.Length > str2.Length ? str1 : str2;
        var shortStr = str1.Length > str2.Length ? str2 : str1;
        string subStr = string.Empty, result = string.Empty;
        for (int i = 1; i <= shortStr.Length; i++)
        {
            subStr = shortStr.Substring(0, i);
            if (IsDividableStr(shortStr, subStr) && IsDividableStr(longStr, subStr))
            {
                result = subStr;
            }
        }
        return result;
    }
    private bool IsDividableStr(string origin, string subStr)
    {
        if (origin.Length % subStr.Length != 0) return false;
        for (int i = 0; i < origin.Length; i += subStr.Length)
        {
            if (!origin.Substring(i, subStr.Length).Equals(subStr)) return false;
        }
        return true;
    }
}