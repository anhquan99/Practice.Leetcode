using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application;
public partial class StackSolution
{
    public string CountOfAtoms(string formula)
    {
        int i = 0, len = formula.Length;
        Stack<Dictionary<string, int>> stack = new Stack<Dictionary<string, int>>();
        stack.Push(new Dictionary<string, int>());
        while (i < len)
        {
            if (formula[i] == '(')
            {
                stack.Push(new Dictionary<string, int>());
                i++;
            }
            else if (formula[i] == ')')
            {
                var top = stack.Pop();
                int start = ++i, num = 1;
                while (i < len && Char.IsDigit(formula[i])) i++;
                if (i > start) num = int.Parse(formula.Substring(start, i - start));
                foreach (var kvp in top)
                    if (stack.Peek().ContainsKey(kvp.Key)) stack.Peek()[kvp.Key] += kvp.Value * num;
                    else stack.Peek().Add(kvp.Key, kvp.Value * num);
            }
            else
            {
                int start = i++;
                while (i < len && Char.IsLower(formula[i])) i++;
                string name = formula.Substring(start, i - start);
                start = i;
                while (i < len && Char.IsDigit(formula[i])) i++;
                int num = i > start ? int.Parse(formula.Substring(start, i - start)) : 1;
                if (stack.Peek().ContainsKey(name)) stack.Peek()[name] += num;
                else stack.Peek().Add(name, num);
            }
        }
        var sb = new StringBuilder();
        var list = stack.Peek().Keys.ToList();
        list.Sort();
        foreach (string c in list)
            sb.Append(c + (stack.Peek()[c] > 1 ? stack.Peek()[c].ToString() : ""));
        return sb.ToString();
    }
}