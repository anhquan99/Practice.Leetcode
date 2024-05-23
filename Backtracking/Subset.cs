namespace Application;
public partial class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>>();
        var subset = new List<int>();
        Permute(nums, result, subset, 0);
        return result;
    }
    void Permute(int[] nums, List<IList<int>> result, List<int> subset, int index)
    {
        result.Add(new List<int>(subset));
        for (int i = index; i < nums.Length; i++)
        {
            subset.Add(nums[i]);
            Permute(nums, result, subset, i + 1);
            subset.RemoveAt(subset.Count - 1);
        }
    }
}