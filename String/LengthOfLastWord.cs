namespace Application;
public partial class StringSolution
{
    public int LengthOfLastWord(string s)
    {
        return s.Trim().Split(' ')[^1].Length;
    }
}