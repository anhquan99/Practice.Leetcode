namespace Application;
public partial class SlidingWindowsSolution
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        var sum = 0;
        int i = 0;
        for (; i < customers.Length; i++)
        {
            if (grumpy[i] == 0)
            {
                sum += customers[i];
            }
        }
        int maxSatisfied = sum;
        int tmpSatisfied = sum;
        for (i = 0; i < customers.Length && i < minutes; i++)
        {
            if (grumpy[i] == 1)
            {
                tmpSatisfied += customers[i];
            }
        }
        maxSatisfied = Math.Max(maxSatisfied, tmpSatisfied);
        for (i = 1; i < customers.Length; i++)
        {
            tmpSatisfied = sum;
            for (int j = i; j < i + minutes && j < customers.Length; j++)
            {
                if (grumpy[j] == 1)
                {
                    tmpSatisfied += customers[j];
                }
            }
            maxSatisfied = Math.Max(maxSatisfied, tmpSatisfied);
        }
        return maxSatisfied;
    }
}