namespace Application;

public partial class MathSolution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int result = 0, emptyBottle = 0, lastBottle = numBottles;
        while (numBottles > 0)
        {
            result += numBottles;
            lastBottle = numBottles;
            numBottles = (lastBottle + emptyBottle) / numExchange;
            emptyBottle = (lastBottle + emptyBottle) % numExchange;
        }
        return result;
    }
}