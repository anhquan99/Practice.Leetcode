using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using Internal;

namespace Application
{
    public partial class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root is null) return false;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int index = 1;
            while (queue.Count > 0)
            {
                int count = queue.Count;
                int left = 0;
                int right = 0;
                List<TreeNode> temp = new List<TreeNode>();
                while (queue.Count > 0)
                {
                    var node = queue.Dequeue();
                    if (node.left is not null)
                    {
                        left++;
                    }
                    temp.Add(node.left);
                    if (node.right is not null)
                    {
                        right++;
                    }
                    temp.Add(node.right);
                }
                if (left != right) return false;
                var first = temp.Take(temp.Count / 2).Select(x => x is null ? -1 : x.val).ToList;
                var second = Enumerable.Reverse(temp.Skip(temp.Count / 2).Select(x => x is null ? -1 : x.val)).ToList();
                for (int i = 0; i < first.Count; i++)
                {
                    if (first[i] != second[i]) return false;
                }
                temp.ForEach(x => queue.Enqueue(x));
            }
            return true;
        }

    }
}