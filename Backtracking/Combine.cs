namespace Application;
public partial class BackTrackingSolution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        if (n == 1 && k == 1) return new List<IList<int>>() { new List<int> { 1 } };
        var result = new List<IList<int>>();
        var list = Enumerable.Range(1, n).ToArray();
        PermuteCombine(new List<int>(), list, 0, k);
        return result;
        void PermuteCombine(List<int> subResult, int[] list, int index, int k)
        {
            if (subResult.Count == k)
            {
                result.Add(new List<int>(subResult));
                return;
            }
            for (int i = index; i < list.Length; i++)
            {
                subResult.Add(list[i]);
                PermuteCombine(subResult, list, i + 1, k);
                subResult.RemoveAt(subResult.Count - 1);
            }
        }
    }

}