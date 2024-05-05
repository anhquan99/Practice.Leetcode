namespace Application;
public partial class MathSolution
{
    public void MoveZeroes(int[] nums)
    {
        var temp = new int[nums.Length];
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                temp[j] = nums[i];
                j++;
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (i <= j)
            {
                nums[i] = temp[i];
            }
            else
            {
                nums[i] = 0;
            }
        }
    }
}