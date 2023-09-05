namespace Application
{
    public partial class Solution
    {
        public bool EvaluateTree(TreeNode root)
        {
            var expression = new List<int>();
            BuildExpression(root, expression);
            var result = Convert.ToBoolean(expression[0]);
            for (int i = 1; i < expression.Count; i += 2)
            {
                if (expression[i] == 2) result = result || Convert.ToBoolean(expression[i + 1]);
                else if (expression[i] == 3) result = result && Convert.ToBoolean(expression[i + 1]);
            }
            return result;
        }
        private void BuildExpression(TreeNode node, List<int> expression)
        {
            if (node is null) return;
            expression.Add(node.val);
            BuildExpression(node.left, expression);
            BuildExpression(node.right, expression);
        }
    }
}