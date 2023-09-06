namespace Application
{
    public partial class Solution
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            var queue = new Queue<int>();
            TravelIncreasingBST(root, queue);
            var head = new TreeNode();
            head.val = queue.Dequeue();
            var node = head;
            while (queue.Count > 0)
            {
                node.right = new TreeNode();
                node.right.val = queue.Dequeue();
                node = node.right;
            }
            return head;
        }
        private void TravelIncreasingBST(TreeNode node, Queue<int> queue)
        {
            if (node is null) return;
            TravelIncreasingBST(node.left, queue);
            queue.Enqueue(node.val);
            TravelIncreasingBST(node.right, queue);
        }
    }
}