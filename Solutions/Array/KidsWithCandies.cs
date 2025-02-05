namespace Application;

public partial class ArraySolution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var result = new bool[candies.Length];
        var max = candies.Max();
        for(int i = 0; i < candies.Length; i++)
        {
           if(candies[i] + extraCandies >= max) result[i] = true;
           else result[i] = false;
        }
        return result;    
    }
}