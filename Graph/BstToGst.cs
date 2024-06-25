namespace Application;

public partial class GraphSolution
{
    public TreeNode BstToGst(TreeNode root)
    {
        var sum = 0;
        TravelBst(root, ref sum);
        return root;
    }
    void TravelBst(TreeNode root, ref int sum)
    {
        if (root == null) return;
        TravelBst(root.right, ref sum);
        sum += root.val;
        root.val = sum;
        TravelBst(root.left, ref sum);
    }
}