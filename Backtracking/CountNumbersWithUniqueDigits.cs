namespace Application;
public partial class BackTrackingSolution
{
    public int CountNumbersWithUniqueDigits(int n)
    {
        if (n == 0) return 1;
        int result = 0;
        Permute(n, new HashSet<int>());
        if (n > 1) return result + 1;
        return result;
        void Permute(int n, HashSet<int> nums)
        {
            if (nums.Count <= n && nums.Count > 0)
            {
                result++;
                if (nums.Count == n) return;
            }
            for (var i = 0; i < 10; i++)
            {
                if (!nums.Add(i)) continue;
                Permute(n, nums);
                nums.Remove(i);
            }
        }
    }

}