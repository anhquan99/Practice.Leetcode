namespace Application;
public partial class MathSolution
{
    public int[] PlusOne(int[] digits)
    {
        var stack = new Stack<int>();
        var remain = false;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (i == digits.Length - 1)
            {
                if (digits[i] == 9)
                {
                    remain = true;
                    stack.Push(0);
                }
                else stack.Push(digits[i] + 1);
            }
            else
            {
                if (remain && digits[i] == 9)
                {
                    stack.Push(0);
                }
                else if (remain)
                {
                    stack.Push(digits[i] + 1);
                    remain = false;
                }
                else
                {
                    stack.Push(digits[i]);
                }
            }
        }
        if (!remain) return stack.ToArray();
        var result = new int[digits.Length + 1];
        var index = 0;
        result[index++] = 1;
        while (stack.Count > 0)
        {
            result[index++] = stack.Pop();
        }
        return result;
    }
}