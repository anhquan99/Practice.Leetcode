namespace Application
{
    public partial class GraphSolution
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root is null) return true;
            var leftHeight = FindDept(root.left);
            var rightHeight = FindDept(root.right);
            GC.Collect();
            return Math.Abs(leftHeight - rightHeight) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
        }
        int FindDept(TreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(FindDept(root.left), FindDept(root.right));
        }

    }
}