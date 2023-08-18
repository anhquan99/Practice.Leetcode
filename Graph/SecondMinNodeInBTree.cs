using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application
{
    public partial class Solution
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            if (root is null) return -1;
            var path = new HashSet<int>();
            TravelSecondMin(root, path);
            if (path.Count == 1) return -1;
            var temp = path.ToList();
            temp.Sort();
            return temp[1];
        }
        public void TravelSecondMin(TreeNode node, HashSet<int> path)
        {
            if (node is null) return;
            path.Add(node.val);
            TravelSecondMin(node.left, path);
            TravelSecondMin(node.right, path);
        }
    }
}