using System;
using System.Text;

namespace Application
{
    public partial class GraphSolution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            var strP = Travel(p);
            var strQ = Travel(q);
            return string.Equals(strP, strQ, StringComparison.OrdinalIgnoreCase);
        }
        string Travel(TreeNode p)
        {
            StringBuilder sb = new StringBuilder();
            InorderTraversal(p, sb);
            return sb.ToString();
        }
        void InorderTraversal(TreeNode node, StringBuilder sb)
        {
            if (node == null)
            {
                sb.Append("null");
                return;
            }
            sb.Append(node.val.ToString());
            InorderTraversal(node.left, sb);
            InorderTraversal(node.right, sb);
        }
    }
}