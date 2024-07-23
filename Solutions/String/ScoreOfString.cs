namespace Application;
public partial class StringSolution
{
    public int ScoreOfString(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        var result = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            result += Math.Abs(s[i] - s[i + 1]);
        }
        return result;
    }
}