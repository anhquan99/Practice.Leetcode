namespace Application
{
    public partial class GraphSolution
    {
        public int SumRootToLeaf(TreeNode root)
        {
            var paths = new List<string>();
            var path = new List<int>();
            FindPathsFromRootToLeaf(root, path, paths);
            var result = 0;
            foreach (var i in paths)
            {
                result += Convert.ToInt32(i, 2);
            }
            return result;
        }
        private void FindPathsFromRootToLeaf(TreeNode node, List<int> path, List<string> paths)
        {
            if (node is null) return;
            path.Add(node.val);
            if (node.left is null && node.right is null)
            {
                paths.Add(string.Join("", path));
            }
            FindPathsFromRootToLeaf(node.left, new List<int>(path), paths);
            FindPathsFromRootToLeaf(node.right, new List<int>(path), paths);
        }
    }
}