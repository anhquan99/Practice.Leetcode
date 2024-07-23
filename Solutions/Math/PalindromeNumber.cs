using System.Text;

namespace Application;
public partial class MathSolution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        var result = x.ToString().ToCharArray();
        return result.SequenceEqual(result.Reverse());
    }
}