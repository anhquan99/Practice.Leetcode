namespace Application;

public partial class BitManipulationSolution
{
    public int SingleNumber(int[] nums)
    {
        var result = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            result = result ^ nums[i];
        }
        return result;
    }
}