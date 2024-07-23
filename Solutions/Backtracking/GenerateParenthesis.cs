namespace Application;
public partial class BackTrackingSolution
{
    List<string> parenthesisResut;
    public IList<string> GenerateParenthesis(int n)
    {
        parenthesisResut = new List<string>();
        PermuteParenthesis(new char[n * 2], 0, 0, 0, n);
        return parenthesisResut;
    }
    void PermuteParenthesis(char[] parenthesis, int pos, int open, int close, int n)
    {
        if (close == n)
        {
            parenthesisResut.Add(new string(parenthesis));
            return;
        }
        if (open > close)
        {
            parenthesis[pos] = ')';
            PermuteParenthesis(parenthesis, pos + 1, open, close + 1, n);
        }
        if (open < n)
        {
            parenthesis[pos] = '(';
            PermuteParenthesis(parenthesis, pos + 1, open + 1, close, n);
        }
    }
    public IList<string> GenerateParenthesisDFS(int n)
    {
        parenthesisResut = new List<string>();
        PermuteParenthesisDFS(n, n, new List<char>());
        return parenthesisResut;
    }
    void PermuteParenthesisDFS(int left, int right, List<char> parenthesis)
    {
        if (left == 0 && right == 0)
        {
            parenthesisResut.Add(new string(parenthesis.ToArray()));
        }
        if (left > right || left < 0 || right < 0)
        {
            return;
        }
        parenthesis.Add('(');
        PermuteParenthesisDFS(left - 1, right, parenthesis);
        parenthesis.RemoveAt(parenthesis.Count - 1);

        parenthesis.Add(')');
        PermuteParenthesisDFS(left, right - 1, parenthesis);
        parenthesis.RemoveAt(parenthesis.Count - 1);
    }
}