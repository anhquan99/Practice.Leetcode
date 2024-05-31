namespace Application;
public partial class BackTrackingSolution
{
    List<IList<int>> _permuteUniqueResult;
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Array.Sort(nums);
        _permuteUniqueResult = new List<IList<int>>();
        PermuteUnique(nums, new List<int>(), new bool[nums.Length]);
        return _permuteUniqueResult;
    }
    void PermuteUnique(int[] nums, List<int> subResult, bool[] used)
    {
        if (subResult.Count == nums.Length)
        {
            _permuteUniqueResult.Add(new List<int>(subResult));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i]) continue;
            if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue;
            subResult.Add(nums[i]);
            used[i] = true;
            PermuteUnique(nums, subResult, used);
            subResult.RemoveAt(subResult.Count - 1);
            used[i] = false;
        }
    }
}