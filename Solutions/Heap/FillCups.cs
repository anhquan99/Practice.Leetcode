namespace Application;
public partial class HeapSolution
{
    public int FillCups(int[] amount)
    {
        var comparer = new Comparison<int>(
                            (i1, i2) => i2.CompareTo(i1)
                    );
        Array.Sort(amount, comparer);
        var count = 0;
        while (amount[0] > 0)
        {
            amount[0]--;
            amount[1]--;
            Array.Sort(amount, comparer);
            count++;
        }
        return count;

    }
}