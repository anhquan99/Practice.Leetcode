namespace Application;
public partial class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        var result = new List<int>();
        Calculate(nums, result, 0, 0);
        return result.Sum();
    }
    void Calculate(int[] nums, List<int> result, int xorResult, int index)
    {
        result.Add(xorResult);
        for (int i = index; i < nums.Length; i++)
        {
            xorResult ^= nums[i];
            Calculate(nums, result, xorResult, i + 1);
            xorResult ^= nums[i];
        }
    }
}