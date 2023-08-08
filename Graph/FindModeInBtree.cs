namespace Application
{
    public partial class Solution
    {
        public int[] FindMode(TreeNode root)
        {
            var nodeMode = new Dictionary<int, int>();
            TravelMode(root, nodeMode);
            int max = nodeMode.Max(x => x.Value);
            return nodeMode.Where(x => x.Value == max).Select(x => x.Key).ToArray();

        }
        public void TravelMode(TreeNode node, Dictionary<int, int> nodeMode)
        {
            if (node is null) return;
            if (nodeMode.ContainsKey(node.val))
            {
                nodeMode[node.val]++;
            }
            else
            {
                nodeMode.Add(node.val, 1);
            }
            TravelMode(node.left, nodeMode);
            TravelMode(node.right, nodeMode);

        }
    }
}