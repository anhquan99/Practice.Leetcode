namespace Application;
public partial class MathSolution
{
    public int PassThePillow(int n, int time)
    {
        int passPreRound = n - 1;
        if (time < passPreRound) return time + 1;
        int cycle = time % (passPreRound * 2);
        if (cycle > passPreRound)
        {
            return n - (cycle % passPreRound);
        }
        return cycle + 1;
    }
}