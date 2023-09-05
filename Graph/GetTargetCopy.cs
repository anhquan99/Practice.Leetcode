namespace Application
{
    public partial class Solution
    {
        private TreeNode clonedNode;
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            TravelClone(cloned, target.val);
            GC.Collect();
            return clonedNode;
        }
        private void TravelClone(TreeNode node, int target)
        {
            if (node is null) return;
            if (node.val == target)
            {
                clonedNode = node;
                return;
            }
            TravelClone(node.left, target);
            TravelClone(node.right, target);
        }
    }
}