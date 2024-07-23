using System.Reflection.Metadata.Ecma335;

namespace Application;
public partial class QueueSolution
{
    // ref: https://algo.monster/liteproblems/1438
    public int LongestSubarray(int[] nums, int limit)
    {
        // int left = 0;
        // var maxLength = 0;
        // var data = new SortedDictionary<int, int>();
        // for (int right = 0; right < nums.Length; right++)
        // {
        //     if (data.ContainsKey(nums[right]))
        //     {
        //         data[nums[right]]++;
        //     }
        //     else
        //     {
        //         data.Add(nums[right], 1);
        //     }
        //     while (data.Last().Key - data.First().Key > limit)
        //     {
        //         if (--data[nums[left]] == 0)
        //         {
        //             data.Remove(nums[left]);
        //         }
        //         left++;
        //     }
        //     maxLength = Math.Max(maxLength, right - left + 1);
        // }
        // return maxLength;
        var min = new DeQueue();
        var max = new DeQueue();
        int j = 0;
        int maxLength = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            while (min.Count() > 0 && nums[min.PeekBack()] >= nums[i])
            {
                min.DeQueueBack();
            }
            min.EnqueueBack(i);
            while (max.Count() > 0 && nums[max.PeekBack()] <= nums[i])
            {
                max.DeQueueBack();
            }
            max.EnqueueBack(i);
            if (nums[max.PeekFront()] - nums[min.PeekFront()] > limit)
            {
                j++;
                if (j > min.PeekFront())
                {
                    min.DeQueueFront();
                }
                if (j > max.PeekFront())
                {
                    max.DeQueueFront();
                }
            }
            else
            {
                maxLength = Math.Max(maxLength, i - j + 1);
            }
        }
        return maxLength;
    }
    class DeQueue
    {
        public List<int> nums;
        public DeQueue()
        {
            nums = new List<int>();
        }
        public void EnqueueBack(int val)
        {
            nums.Add(val);
        }
        public void DeQueueBack()
        {
            nums.RemoveAt(nums.Count - 1);
        }
        public void DeQueueFront()
        {
            nums.RemoveAt(0);
        }
        public int PeekFront()
        {
            return nums[0];
        }
        public int PeekBack()
        {
            return nums[^1];
        }
        public int Count()
        {
            return nums.Count;
        }
    }
}
