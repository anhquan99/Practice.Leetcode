namespace Application;
public partial class QueueSolution
{
    public int MaxSubarraySumCircular(int[] nums)
    {
        // Initialize variables to hold
        // s1 and s2 as the max and min subarray sums respectively
        // f1 and f2 as the local max and min subarray sums at the current position
        // total as the sum of all numbers in the array
        int maxSubarraySum = nums[0], minSubarraySum = nums[0];
        int currentMaxSum = nums[0], currentMinSum = nums[0], totalSum = nums[0];

        // Iterate through the array starting from the second element
        for (int i = 1; i < nums.Length; ++i)
        {
            // Update the total sum
            totalSum += nums[i];

            // Calculate the local max subarray sum (Kadane's algorithm)
            currentMaxSum = nums[i] + Math.Max(currentMaxSum, 0);
            // Determine the global max subarray sum so far
            maxSubarraySum = Math.Max(maxSubarraySum, currentMaxSum);

            // Calculate the local min subarray sum (Inverse Kadane's algorithm)
            currentMinSum = nums[i] + Math.Min(currentMinSum, 0);
            // Determine the global min subarray sum so far
            minSubarraySum = Math.Min(minSubarraySum, currentMinSum);
        }

        // If maxSubarraySum is non-positive, all numbers are non-positive.
        // Hence, return maxSubarraySum because wrapping doesn't make sense.
        // Otherwise, return the maximum between maxSubarraySum and
        // totalSum - minSubarraySum which represents the maximum circular subarray sum.
        nums.Sum();
        return maxSubarraySum > 0 ? Math.Max(maxSubarraySum, totalSum - minSubarraySum) : maxSubarraySum;
    }
    // Kadane's algorithm
    public int maxSubArraySum(int[] a)
    {
        int size = a.Length;
        int max_so_far = int.MinValue, max_ending_here = 0;

        for (int i = 0; i < size; i++)
        {
            max_ending_here = max_ending_here + a[i];

            if (max_so_far < max_ending_here)
                max_so_far = max_ending_here;

            if (max_ending_here < 0)
                max_ending_here = 0;
        }

        return max_so_far;
    }
}