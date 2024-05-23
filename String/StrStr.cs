namespace Application;
public partial class StringSolution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length == 1 && needle.Length == 1)
        {
            if (haystack[0] == needle[0]) return 0;
            else return -1;
        }
        var index = 0;
        while (index + needle.Length <= haystack.Length)
        {
            if (haystack.Substring(index, needle.Length) == needle)
            {
                return index;
            }
            index++;
        }
        return -1;
    }
}