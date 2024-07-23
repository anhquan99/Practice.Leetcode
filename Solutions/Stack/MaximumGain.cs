using System.Text;

namespace Application;
public partial class StackSolution
{
    public int MaximumGain(string s, int x, int y)
    {
        if (x < y)
        {
            var reverse = s.ToCharArray();
            Array.Reverse(reverse);
            return MaximumGain(new string(reverse), y, x);
        }
        int result = 0;
        Stack<char> stack1 = new Stack<char>(), stack2 = new Stack<char>();
        foreach (char c in s)
        {
            if (c != 'b')
            {
                stack1.Push(c);
            }
            else
            {
                if (stack1.Count > 0 && stack1.Peek() == 'a')
                {
                    stack1.Pop();
                    result += x;
                }
                else
                {
                    stack1.Push(c);
                }
            }
        }
        while (stack1.Count > 0)
        {
            var currentChar = stack1.Pop();
            if (currentChar != 'b')
            {
                stack2.Push(currentChar);
            }
            else
            {
                if (stack2.Count > 0 && stack2.Peek() == 'a')
                {
                    stack2.Pop();
                    result += y;
                }
                else
                {
                    stack2.Push(currentChar);
                }
            }
        }
        return result;
    }
}