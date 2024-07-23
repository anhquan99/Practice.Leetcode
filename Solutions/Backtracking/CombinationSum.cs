namespace Application;
public partial class BackTrackingSolution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var combinationSumResult = new List<IList<int>>();
        PermuteCombinationSum(new List<int>(), candidates, 0, target);
        return combinationSumResult;
        void PermuteCombinationSum(List<int> subResult, int[] candidates, int index, int target)
        {
            var sum = subResult.Sum();
            if (sum >= target || index >= candidates.Length)
            {
                if (sum == target)
                {
                    combinationSumResult.Add(new List<int>(subResult));
                }
                return;
            }
            for (int i = index; i < candidates.Length; i++)
            {
                subResult.Add(candidates[i]);
                PermuteCombinationSum(subResult, candidates, i, target);
                subResult.RemoveAt(subResult.Count - 1);
            }
        }
    }

}