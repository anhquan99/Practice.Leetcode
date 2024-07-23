namespace Application;
public partial class GraphSolution
{
    public IList<string> RemoveSubfolders(string[] folder)
    {
        Array.Sort(folder, (a, b) => a.Length.CompareTo(b.Length));
        var root = new Trie();
        var result = new List<string>();
        foreach (var i in folder)
        {
            if (InsertFolder(root, i.Substring(1, i.Length - 1).Split('/'))) result.Add(i);
        }
        return result;
    }
    class Trie
    {
        public bool End { get; set; }
        private Dictionary<string, Trie> Nodes { get; set; }
        public Trie()
        {
            Nodes = new Dictionary<string, Trie>();
            End = false;
        }
        public Trie this[string index]
        {
            get => Nodes.ContainsKey(index) ? Nodes[index] : null;
            set => Nodes[index] = value;
        }
    }
    bool InsertFolder(Trie root, string[] folders)
    {
        var currentNode = root;
        foreach (var i in folders)
        {
            if (currentNode[i] == null)
            {
                currentNode[i] = new Trie();
            }
            else if (currentNode[i] != null && currentNode[i].End) return false;
            currentNode = currentNode[i];
        }
        currentNode.End = true;
        return true;
    }
}