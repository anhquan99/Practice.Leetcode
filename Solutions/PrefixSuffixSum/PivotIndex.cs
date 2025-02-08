using System.Collections;

namespace Application;
public partial class PrefixSuffixSumSolution
{
    public int PivotIndex(int[] nums)
    {
        int rightSum = nums.Sum(), leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum == rightSum - leftSum - nums[i])
            {
                return i;
            }
            leftSum += nums[i];
        }
        return -1;
    }
}
