using System.Globalization;

namespace Application
{
    public partial class GraphSolution
    {
        public int MinExtraChar(string s, string[] dictionary)
        {
            HashSet<string> ss = new HashSet<string>();
            foreach (string w in dictionary)
            {
                ss.Add(w);
            }
            int n = s.Length;
            int[] f = new int[n + 1];
            f[0] = 0;
            for (int i = 1; i <= n; ++i)
            {
                f[i] = f[i - 1] + 1;
                for (int j = 0; j < i; ++j)
                {
                    if (ss.Contains(s.Substring(j, i - j)))
                    {
                        f[i] = Math.Min(f[i], f[j]);
                    }
                }
            }
            return f[n];
        }
    }
}