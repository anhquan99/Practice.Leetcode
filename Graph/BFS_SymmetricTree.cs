using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public partial class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node.left == null && node.right == null) continue;
                if ((node.left != null && node.right == null) || (node.left == null && node.right != null)) return false;

            }
        }
        bool Traversal(TreeNode node)
        {
            if (node.left == null && node.right == null) return true;
            else if ((node.left != null && node.right == null) || (node.left == null && node.right != null)) return false;
            else return InorderTraversal(node.left) && InorderTraversal(node.right);
        }
    }
}