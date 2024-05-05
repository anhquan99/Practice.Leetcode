namespace Application;
public partial class StringSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";
        var result = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            for (int j = 0; j < result.Length; j++)
            {
                if (j == strs[i].Length)
                {
                    result = result.Substring(0, j);
                    break;
                }
                if (result[j] != strs[i][j])
                {
                    result = result.Substring(0, j);
                    break;
                }

            }
        }
        return result;
    }
}