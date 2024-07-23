namespace Application
{
    public partial class GraphSolution
    {
        public int MaxDepth(TreeNode root)
        {
            int max = 0;
            TravelMaxDepth(root, new List<int>(), ref max);
            return max;
        }
        public void TravelMaxDepth(TreeNode node, List<int> path, ref int max)
        {
            if (node is null) return;
            path.Add(node.val);
            if (max < path.Count) max = path.Count;
            Travel(node.left, new List<int>(path), max);
            Travel(node.right, new List<int>(path), max);
        }
        // public int MaxDepth(TreeNode root)
        // {
        //     if (root == null)
        //         return 0;

        //     return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        // }
    }
}