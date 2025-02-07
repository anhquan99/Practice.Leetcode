using System.Text;

namespace Application;
public partial class StringSolution
{
    private List<char> _vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
    public string ReverseVowels(string s)
    {
        int left = 0, right = s.Length - 1;
        var sb = new StringBuilder(s);
        left = FindNextLeftVowel(s, left);
        right = FindNextRightVowel(s, right);
        var tmp = sb[0];
        while (left < right)
        {
            tmp = sb[left];
            sb[left] = sb[right];
            sb[right] = tmp;
            left = FindNextLeftVowel(s, ++left);
            right = FindNextRightVowel(s, --right);
        }
        return sb.ToString();

    }
    private int FindNextLeftVowel(string s, int left)
    {
        while (left < s.Length)
        {
            if (_vowels.Contains(char.ToLower(s[left]))) break;
            left++;
        }
        return left;
    }
    private int FindNextRightVowel(string s, int right)
    {
        while (right > 0)
        {
            if (_vowels.Contains(char.ToLower(s[right]))) break;
            right--;
        }
        return right;
    }
}