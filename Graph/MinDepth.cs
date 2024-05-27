namespace Application
{
    public partial class GraphSolution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left is not null && root.right is null) return 1 + MinDepth(root.left);
            else if (root.right is not null && root.left is null) return 1 + MinDepth(root.right);
            else return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
        }
    }
}