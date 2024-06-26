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
        void InsertWordsToDic(ExtraCharTrie root, string[] dic)
        {
            if (dic == null) return;
            foreach (var word in dic)
            {
                InsertWordToTrie(word, root);
            }
        }
        class ExtraCharTrie
        {
            public bool End { get; set; }
            private Dictionary<char, ExtraCharTrie> Nodes { get; set; }
            public ExtraCharTrie()
            {
                Nodes = new Dictionary<char, ExtraCharTrie>();
                End = false;
            }
            public ExtraCharTrie this[char ch]
            {
                get => Nodes.ContainsKey(ch) ? Nodes[ch] : null;
                set => Nodes[ch] = value;
            }
        }
        void InsertWordToTrie(string word, ExtraCharTrie root)
        {
            var tmp = root;
            foreach (var ch in word)
            {
                if (tmp[ch] == null)
                {
                    tmp[ch] = new();
                }
                tmp = tmp[ch];
            }
            tmp.End = true;
        }
    }
}