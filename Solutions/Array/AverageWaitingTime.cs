namespace Application;

public partial class ArraySolution
{
    public double AverageWaitingTime(int[][] customers)
    {
        int sumTime = customers[0][1], currTime = customers[0][1] + customers[0][0];
        int waitTime = 0, nextCurrTime = 0;
        for (int i = 1; i < customers.Length; i++)
        {
            if (currTime > customers[i][0])
            {
                waitTime = (currTime + customers[i][1]) - customers[i][0];
                nextCurrTime = currTime + customers[i][1];
            }
            else
            {
                waitTime = customers[i][1];
                nextCurrTime = customers[i][0] + customers[i][1];
            }
            sumTime += waitTime;
            currTime = nextCurrTime;
        }
        return (double)sumTime / customers.Length;
    }
}