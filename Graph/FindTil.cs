namespace Application
{
    public partial class Solution
    {
        public int FindTilt(TreeNode root)
        {
            if (root is null) return 0;
            TravelSumTil(root.left);
            TravelSumTil(root.right);
            var tilArr = new List<int>();
            TravelTil(root, tilArr);
            GC.Collect();
            return tilArr.Sum();
        }
        private void TravelSumTil(TreeNode node)
        {
            if (node is null) return;
            TravelSumTil(node.left);
            TravelSumTil(node.right);
            var left = node.left is null ? 0 : node.left.val;
            var right = node.right is null ? 0 : node.right.val;
            node.val += left + right;
        }
        private void TravelTil(TreeNode node, List<int> tilArr)
        {
            if (node is null) return;
            TravelTil(node.left, tilArr);
            TravelTil(node.right, tilArr);
            var left = node.left is null ? 0 : node.left.val;
            var right = node.right is null ? 0 : node.right.val;
            tilArr.Add(Math.Abs(left - right));
        }
    }
}