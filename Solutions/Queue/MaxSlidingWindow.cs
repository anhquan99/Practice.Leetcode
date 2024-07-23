namespace Application;
public partial class QueueSolution
{
    // ref: https://algo.monster/problems/sliding_window_maximum
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var q = new LinkedList<int>(); // stores *indices*
        var res = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            while (q.Count != 0 && nums[q.Last()] <= nums[i])
            {
                q.RemoveLast();
            }
            q.AddLast(i);
            // remove first element if it's outside the window
            if (q.First() == i - k)
            {
                q.RemoveFirst();
            }
            // if window has k elements add to results (first k-1 windows have < k elements because we start from empty window and add 1 element each iteration)
            if (i >= k - 1)
            {
                res.Add(nums[q.First()]);
            }
        }
        return res.ToArray();
    }

}