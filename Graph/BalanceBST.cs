namespace Application
{
    public partial class GraphSolution
    {
        public TreeNode BalanceBST(TreeNode root)
        {
            if (root == null) return null;
            var values = new List<int>();
            InOrderBalanceBST(root, values);
            return InsertBalanceBST(null, values, 0, values.Count);
        }
        void InOrderBalanceBST(TreeNode root, List<int> values)
        {
            if (root == null) return;
            InOrderBalanceBST(root.left, values);
            values.Add(root.val);
            InOrderBalanceBST(root.right, values);
        }
        TreeNode InsertBalanceBST(TreeNode root, List<int> values, int left, int right)
        {
            if (left > right || left >= values.Count) return null;
            var mid = (right + left) / 2;
            root = new TreeNode(values[mid]);
            root.left = InsertBalanceBST(root, values, left, mid - 1);
            root.right = InsertBalanceBST(root, values, mid + 1, right);
            return root;
        }
    }
}