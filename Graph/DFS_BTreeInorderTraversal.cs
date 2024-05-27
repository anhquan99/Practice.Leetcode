using System;

namespace Application
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public partial class GraphSolution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            InorderTraversal(root, result);
            return result;
        }
        private void InorderTraversal(TreeNode node, List<int> result)
        {
            if (node == null) return;
            InorderTraversal(node.left, result);
            result.Add(node.val);
            InorderTraversal(node.right, result);
        }
    }
}