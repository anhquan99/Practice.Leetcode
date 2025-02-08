using System.Collections;

namespace Application;
public partial class PrefixSuffixSumSolution
{
    public int SubarraysDivByK(int[] nums, int k)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0] % k == 0 ? 1 : 0;
        var dic = new Dictionary<int, int>();
        dic.Add(0, 1);
        var count = 0;
        var sum = 0;
        foreach (var i in nums)
        {
            sum = ((sum + i) % k + k) % k; ;
            count += dic.ContainsKey(sum) ? dic[sum] : 0;
            if (dic.ContainsKey(sum))
            {
                dic[sum]++;
            }
            else
            {
                dic.Add(sum, 1);
            }
        }
        return count;
    }
}
