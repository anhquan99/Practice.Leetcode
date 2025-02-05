namespace Application;
public partial class DynamicProgrammingSolution
{
    int FindMaxNumTeam(int[] rating, int lastIndex, int count)
    {
        var isFound = false;
        var currIndex = lastIndex + 1;
        while (lastIndex < rating.Length && rating[lastIndex] > rating[currIndex])
        {
            if (rating[lastIndex] < rating[currIndex])
            {
                count++;
                isFound = true;
                break;
            }
            currIndex++;
        }
        if (isFound && count != 3)
        {
            return FindMaxNumTeam(rating, currIndex, count);
        }
        else if (count == 3)
        {
            return 1;
        }
        return 0;

    }

}