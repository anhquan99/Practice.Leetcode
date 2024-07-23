namespace Application;
public partial class GraphSolution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums == null || nums.Length == 0) return null;
        var result = DivTree(nums, 0, nums.Length);
        return result;
    }
    TreeNode DivTree(int[] nums, int min, int max)
    {
        if (min >= max) return null;
        var mid = (min + max) / 2;
        var node = new TreeNode(nums[mid]);
        node.left = DivTree(nums, min, mid);
        node.right = DivTree(nums, mid + 1, max);
        return node;
    }
}