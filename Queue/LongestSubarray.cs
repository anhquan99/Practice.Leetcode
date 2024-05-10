using System.Reflection.Metadata.Ecma335;

namespace Application;
public partial class QueueSolution
{
    // ref: https://algo.monster/liteproblems/1438
    public int LongestSubarray(int[] nums, int limit)
    {
        int left = 0;
        var maxLength = 0;
        var data = new SortedDictionary<int, int>();
        for (int right = 0; right < nums.Length; right++)
        {
            if (data.ContainsKey(nums[right]))
            {
                data[nums[right]]++;
            }
            else
            {
                data.Add(nums[right], 1);
            }
            while (data.Last().Key - data.First().Key > limit)
            {
                if (--data[nums[left]] == 0)
                {
                    data.Remove(nums[left]);
                }
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }

}