namespace Application
{
    public partial class GraphSolution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            List<int> path = new List<int>();
            path.Add(root.val);
            return Travel(root.left, path, targetSum) || Travel(root.right, path, targetSum);
        }
        public bool Travel(TreeNode node, List<int> path, int targetSum)
        {
            if (node is null) return false;
            path.Add(node.val);
            if (node.left is null && node.right is null && path.Sum(x => x) == targetSum) return true;
            return Travel(node.left, new List<int>(path), targetSum) || Travel(node.right, new List<int>(path), targetSum);
        }
    }
}