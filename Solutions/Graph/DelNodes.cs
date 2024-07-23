namespace Application
{
    public partial class GraphSolution
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            var result = new List<TreeNode>();
            var hs = to_delete.ToHashSet();
            hs.Add(0);
            DelNodesTravel(root, 0, hs, result);
            return result;
        }
        void DelNodesTravel(TreeNode root, int lastNodeVal, HashSet<int> to_delete, List<TreeNode> result)
        {
            if (root == null) return;
            if (to_delete.Contains(lastNodeVal) && !to_delete.Contains(root.val)) result.Add(root);
            if (root.left != null)
            {
                DelNodesTravel(root.left, root.val, to_delete, result);
                if (to_delete.Contains(root.left.val)) root.left = null;
            }
            if (root.right != null)
            {
                DelNodesTravel(root.right, root.val, to_delete, result);
                if (to_delete.Contains(root.right.val)) root.right = null;
            }
            if (to_delete.Contains(root.val))
            {
                root.left = null;
                root.right = null;
            }
        }

    }
}