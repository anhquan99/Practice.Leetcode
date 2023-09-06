namespace Application
{
    public partial class Solution
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 is null && root2 is null) return null;
            if (root1 is not null)
            {
                Merge2Trees(root1, root2, false);
                return root1;
            }
            Merge2Trees(root2, root1, false);
            return root2;
        }
        private void Merge2Trees(TreeNode node1, TreeNode node2, bool isNew)
        {
            if (node1 is null) return;
            if (node2 is not null && !isNew) node1.val += node2.val;
            var newTree = false;
            if (node1.left is null && node2?.left is not null)
            {
                node1.left = new TreeNode() { val = node2.left.val };
                newTree = true;
            }
            Merge2Trees(node1.left, node2?.left, newTree);
            newTree = false;
            if (node1.right is null && node2?.right is not null)
            {
                node1.right = new TreeNode() { val = node2.right.val };
                newTree = true;
            }
            Merge2Trees(node1.right, node2?.right, newTree);
        }
    }
}