namespace Application
{
    public partial class GraphSolution
    {
        public int GetMinimumDifference(TreeNode root)
        {
            var list = new List<int>();
            TravelMin(root, list);
            list.Sort();
            int min = int.MaxValue;
            for (int i = 0; i < list.Count - 1; i++)
            {
                var diff = Math.Abs(list[i] - list[i + 1]);
                min = min > diff ? diff : min;
            }
            return min;
        }
        public void TravelMin(TreeNode node, List<int> list)
        {
            if (node is null) return;
            list.Add(node.val);
            TravelMin(node.left, list);
            TravelMin(node.right, list);
        }
    }
}