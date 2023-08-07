namespace Application
{
    public partial class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            return TravelSumLeftLeave(root, sum);
        }
        public int TravelSumLeftLeave(TreeNode node, int sum, bool isLeft = false)
        {
            if (node is null) return sum;
            if (isLeft && node.left is null && node.right is null)
            {
                sum += node.val;
                return sum;
            }
            sum += TravelSumLeftLeave(node.left, sum, true);
            sum += TravelSumLeftLeave(node.right, sum);
            return sum;
        }
    }
}