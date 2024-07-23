namespace Application
{
    public partial class GraphSolution
    {
        public bool EvaluateTree(TreeNode root)
        {
            if (root.val == 0 || root.val == 1) return Convert.ToBoolean(root.val);
            return TravelEvaluateTree(root);
        }
        private bool TravelEvaluateTree(TreeNode node)
        {
            if (node.val == 2)
            {
                return TravelEvaluateTree(node.left) || TravelEvaluateTree(node.right);
            }
            else if (node.val == 3)
            {
                return TravelEvaluateTree(node.left) && TravelEvaluateTree(node.right);
            }
            return Convert.ToBoolean(node.val);
        }

    }
}