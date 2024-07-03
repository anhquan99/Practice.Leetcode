namespace Application;

public partial class ArraySolution
{
    public int MinDifference(int[] nums)
    {
        if (nums.Length <= 4) return 0;
        Array.Sort(nums);
        var result = int.MaxValue;
        for (int i = 0; i <= 3; i++)
        {
            int largeIndex = 3 - i;
            var min = nums[nums.Length - 1 - largeIndex] - nums[i];
            result = Math.Min(result, min);
        }
        return result;
    }
}