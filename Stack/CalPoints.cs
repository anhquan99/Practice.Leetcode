namespace Application;
public partial class Solution
{
    public int CalPoints(string[] operations)
    {
        var lastScore = 0;
        var stack = new Stack<int>();
        foreach (var i in operations)
        {
            switch (i)
            {
                case "+":
                    stack.Push(lastScore + stack.Peek());
                    break;
                case "D":
                    stack.Push(stack.Peek() * 2);
                    break;
                case "C":
                    if (stack.Count == 0)
                    {
                        break;
                    }
                    stack.Pop();
                    lastScore = stack.Peek();
                    break;
                default:
                    var parseRecord = int.Parse(i);
                    stack.Push(parseRecord);
                    lastScore = parseRecord;
                    break;
            }
        }
        var result = 0;
        while (stack.Count > 0)
        {
            result += stack.Pop();
        }
        return result;
    }
}