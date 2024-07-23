namespace Application
{
    public partial class GraphSolution
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root is null) return 0;
            int leftSubTreeDepth = DiameterOfBinaryTree(root.left);
            int rightSubTreeDepth = DiameterOfBinaryTree(root.right);
            int diameter = TravelDiameter(root.left) + TravelDiameter(root.right);
            diameter = Math.Max(diameter, Math.Max(leftSubTreeDepth, rightSubTreeDepth));
            return diameter;

        }
        public int TravelDiameter(TreeNode node)
        {
            if (node is null) return 0;
            int leftSubDiameter = TravelDiameter(node.left);
            int rightSubDiameter = TravelDiameter(node.right);
            return Math.Max(leftSubDiameter, rightSubDiameter) + 1;
        }
    }
}