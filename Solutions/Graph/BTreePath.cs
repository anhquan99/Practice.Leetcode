namespace Application
{
    public partial class GraphSolution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<int> path = new();
            List<string> paths = new();
            TravelBPath(root, path, paths);
            return paths;
        }
        private void TravelBPath(TreeNode node, List<int> path, List<string> paths)
        {
            if (node is null) return;
            path.Add(node.val);
            if (node.left is null && node.right is null)
            {
                paths.Add(string.Join("->", path));
            }
            TravelBPath(node.left, new List<int>(path), paths);
            TravelBPath(node.right, new List<int>(path), paths);
        }
    }
}