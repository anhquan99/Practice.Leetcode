using System.Text;

namespace Application;
public partial class MathSolution
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0") return "0";
        List<string> multiplyResult = new List<string>();
        var longStr = num1.Length > num2.Length ? num1 : num2;
        var shortStr = num1.Length > num2.Length ? num2 : num1;
        for (int i = shortStr.Length - 1; i >= 0; i--)
        {
            multiplyResult.Add(MultiplySingleNumber(longStr, int.Parse(shortStr[i].ToString()), shortStr.Length - 1 - i));
        }
        return SumMultiply(multiplyResult);
    }
    string MultiplySingleNumber(string longStr, int subShortStr, int index)
    {
        var sb = new StringBuilder();
        int i;
        for (i = 0; i < index; i++)
        {
            sb.Append("0");
        }
        int remain = 0;
        for (i = longStr.Length - 1; i >= 0; i--)
        {
            int multiply = subShortStr * int.Parse(longStr[i].ToString()) + remain;
            sb.Append(multiply % 10);
            remain = multiply / 10;
        }
        if (remain > 0)
        {
            sb.Append(remain);
        }
        return new string(sb.ToString().Reverse().ToArray());
    }
    string SumMultiply(List<string> strs)
    {
        char[] result = new char[strs[^1].Length + 1];
        for (int i = 0; i < strs.Count; i++)
        {
            strs[i] = new string('0', result.Length - strs[i].Length) + strs[i];
        }
        int remain = 0;
        for (int i = result.Length - 1; i >= 0; i--)
        {
            int sum = 0;
            foreach (string str in strs)
            {
                sum += int.Parse(str[i].ToString());
            }
            sum += remain;
            remain = sum / 10;
            sum = sum % 10;
            result[i] = (char)(sum + '0'); ;
        }
        if (remain > 0)
        {
            result[0] = (char)(remain + '0');
        }
        if (result[0] == '0')
        {
            return new string(result.Skip(1).Take(result.Length - 1).ToArray());
        }
        return new string(result);
    }
}