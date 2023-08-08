namespace Application
{
    public partial class Solution
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            int max = 0;
            TravelDiameter(root, 0, ref max);
            return max;
        }
        public void TravelDiameter(TreeNode node, int dept, ref int max)
        {
            if (node is null) return;
            dept++;
            if (dept > max) max = dept;
            TravelDiameter(node.left, dept, ref max);
            TravelDiameter(node.right, dept, ref max);
        }
    }
}