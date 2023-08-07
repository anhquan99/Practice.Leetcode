namespace Application
{
    public partial class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            TravelSumLeftLeave(root, ref sum);
            return sum;
        }
        public void TravelSumLeftLeave(TreeNode node, ref int sum, bool isLeft = false)
        {
            if (node is null) return;
            TravelSumLeftLeave(node.left, ref sum, true);
            TravelSumLeftLeave(node.right, ref sum);
            if (isLeft && node.left is null && node.right is null)
            {
                sum += node.val;
            }
        }
    }
}