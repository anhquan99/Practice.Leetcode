namespace Application
{
    public partial class GraphSolution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root is null) return root;
            var tempNode = root.left;
            root.left = root.right;
            root.right = tempNode;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }
    }
}