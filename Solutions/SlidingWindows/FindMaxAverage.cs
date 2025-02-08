namespace Application;
public partial class SlidingWindowsSolution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int sum = 0, count = 0, roundUp = 5;
        for (int i = 0; i < k && i < nums.Length; i++)
        {
            sum += nums[i];
            count++;
        }
        double maxAvg = Math.Round((double)sum / count, roundUp);
        for (int i = k; i < nums.Length; i++)
        {
            sum -= nums[i - k];
            sum += nums[i];
            maxAvg = Math.Max(maxAvg, Math.Round((double)sum / k, roundUp));
        }
        return maxAvg;
    }
}