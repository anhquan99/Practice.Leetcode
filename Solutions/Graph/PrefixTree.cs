namespace Application;
public partial class GraphSolution
{
    public class TrieGraph
    {

        class TrieNode
        {
            private Dictionary<char, TrieNode> _trie;
            public bool End { get; set; }
            public TrieNode()
            {
                _trie = new Dictionary<char, TrieNode>();
            }
            public TrieNode this[char index]
            {
                get => _trie.ContainsKey(index) ? _trie[index] : null;
                set => _trie[index] = value;
            }
        }
        private TrieNode _root;
        public TrieGraph()
        {
            _root = new TrieNode();
        }

        public void Insert(string word)
        {
            var tmp = _root;
            foreach (var ch in word)
            {
                if (tmp[ch] == null)
                {
                    tmp[ch] = new TrieNode();
                }
                tmp = tmp[ch];
            }
            tmp.End = true;
        }

        public bool Search(string word)
        {
            var tmp = _root;
            foreach (var ch in word)
            {
                if (tmp[ch] == null) return false;
                tmp = tmp[ch];
            }
            return tmp.End;
        }

        public bool StartsWith(string prefix)
        {
            var tmp = _root;
            foreach (var ch in prefix)
            {
                if (tmp[ch] == null) return false;
                tmp = tmp[ch];
            }
            return true;
        }
    }
}