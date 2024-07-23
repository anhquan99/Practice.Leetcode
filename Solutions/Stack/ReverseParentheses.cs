using System.Diagnostics;
using System.Text;

namespace Application;
public partial class StackSolution
{
    public string ReverseParentheses(string s)
    {
        int length = s.Length;
        int[] pairIndex = new int[length];
        var stack = new Stack<int>();
        for (int i = 0; i < length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else if (s[i] == ')')
            {
                int j = stack.Pop();
                pairIndex[i] = j;
                pairIndex[j] = i;
            }
        }
        var sb = new StringBuilder();
        int index = 0;
        int direction = 1;
        while (index < length)
        {
            if (s[index] == '(' || s[index] == ')')
            {
                index = pairIndex[index];
                direction = -direction; ;
            }
            else
            {
                sb.Append(s[index]);
            }
            index += direction;
        }
        return sb.ToString();
    }
}