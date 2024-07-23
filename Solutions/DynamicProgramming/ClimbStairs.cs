namespace Application;
public partial class DynamicProgrammingSolution
{
    public int ClimbStairs(int n)
    {
        int prev = 1, curr = 1;
        for (int i = 1; i < n; i++)
        {
            var temp = curr;
            curr += prev;
            prev = temp;
        }
        return curr;
    }

}