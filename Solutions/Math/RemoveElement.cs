namespace Application;
public partial class MathSolution
{
    public int RemoveElement(ref int[] nums, int val)
    {
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}