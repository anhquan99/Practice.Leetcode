using System.Globalization;

namespace Application
{
    public partial class GraphSolution
    {
        public int MinExtraChar(string s, string[] dictionary)
        {
            var root = new ExtraCharTrie();
            InsertWordsToDic(root, dictionary);
            var result = 0;
            int slow = 0, fast = 0;
            var tmp = root;
            var end = true;
            for (; fast < s.Length; fast++)
            {
                if (tmp[s[fast]] != null)
                {
                    tmp = tmp[s[fast]];
                    if (tmp.End)
                    {
                        slow = fast;
                        end = true;
                    }
                    else
                    {
                        end = false;
                    }
                }
                else
                {
                    tmp = root;
                    slow = end ? fast : slow;
                    while (fast <= s.Length - 1 && tmp[s[fast]] == null)
                    {
                        fast++;
                    }
                    result += fast - slow;
                    slow = fast;
                    if (fast < s.Length)
                    {
                        tmp = tmp[s[fast]];
                    }
                    else tmp = null;
                    if (tmp != null)
                    {
                        if (tmp.End)
                        {
                            slow = fast;
                            end = true;
                        }
                        else
                        {
                            end = false;
                        }
                    }
                }
            }
            if (!end)
            {
                result += s.Length - slow;
            }
            return result;
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