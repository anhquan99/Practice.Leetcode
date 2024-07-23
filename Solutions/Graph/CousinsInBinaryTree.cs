namespace Application
{
    public partial class GraphSolution
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            var paths = new List<List<int>>();
            var path = new List<int>();
            FindPathsIsCousins(root, path, paths, x);
            path = new List<int>();
            FindPathsIsCousins(root, path, paths, y);
            GC.Collect();
            return paths[0].Count == paths[1].Count && paths[0][paths[1].Count - 2] != paths[1][paths[1].Count - 2];
        }
        private void FindPathsIsCousins(TreeNode node, List<int> path, List<List<int>> paths, int target)
        {
            if (node is null) return;
            path.Add(node.val);
            if (node.val == target)
            {
                paths.Add(path);
            }
            FindPathsIsCousins(node.left, new List<int>(path), paths, target);
            FindPathsIsCousins(node.right, new List<int>(path), paths, target);
        }
    }
}