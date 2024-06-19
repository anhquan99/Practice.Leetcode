namespace Application
{
    public partial class GraphSolution
    {
        public int CountPrefixSuffixPairs(string[] words)
        {
            var result = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (IsPrefixAndSuffix(words[i], words[j])) result++;
                }
            }
            return result;
        }
        bool IsPrefixAndSuffix(string str1, string str2)
        {
            return str2.StartsWith(str1) && str2.EndsWith(str1);
        }
    }
}