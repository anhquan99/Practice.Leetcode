using System.Text;

namespace Application;
public partial class StackSolution
{
    public bool BackspaceCompare(string s, string t)
    {
        return IterateString(t) == IterateString(s);

    }
    string IterateString(string s)
    {
        var stack = new Stack<char>();
        int debt = 0;
        foreach (var i in s)
        {
            if (i == '#')
            {
                if (stack.Count > 0 || debt-- > 0)
                {
                    stack.Pop();
                }
                else
                {
                    debt++;
                }
            }
            else
            {
                stack.Push(i);
            }
        }
        var sb = new StringBuilder();
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }
        return sb.ToString();
    }
}