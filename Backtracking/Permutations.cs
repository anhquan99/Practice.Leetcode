namespace Application;
public partial class BackTrackingSolution
{
    List<IList<int>> _permuteResult;
    public IList<IList<int>> Permute(int[] nums)
    {
        _permuteResult = new List<IList<int>>();
        Permute(nums, new List<int>(), new bool[nums.Length]);
        return _permuteResult;
    }
    void Permute(int[] nums, List<int> subResult, bool[] used)
    {
        if (subResult.Count == nums.Length)
        {
            _permuteResult.Add(new List<int>(subResult));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i]) continue;
            subResult.Add(nums[i]);
            used[i] = true;
            Permute(nums, subResult, used);
            subResult.RemoveAt(subResult.Count - 1);
            used[i] = false;
        }

    }
}