namespace Application
{
    public partial class Solution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            return TravelUnivalTree(root.left, root.val) && TravelUnivalTree(root.right, root.val);
        }
        private bool TravelUnivalTree(TreeNode node, int preValue)
        {
            if (node is null) return true;
            if (node.val != preValue) return false;
            return TravelUnivalTree(node.left, node.val) && TravelUnivalTree(node.right, node.val);
        }
    }
}