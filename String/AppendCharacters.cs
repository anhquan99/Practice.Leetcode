using System.Text;

namespace Application;
public partial class StringSolution
{
    public int AppendCharacters(string s, string t)
    {
        int indexS = 0, indexT = 0;
        while (indexS < s.Length && indexT < t.Length)
        {
            if (s[indexS] == t[indexT])
            {
                indexT++;
            }
            indexS++;
        }
        return t.Length - indexT;
    }
}