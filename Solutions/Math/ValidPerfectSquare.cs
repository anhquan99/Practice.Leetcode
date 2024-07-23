namespace Application;
public partial class MathSolution
{
    public bool IsPerfectSquare(int num)
    {
        if (num == 1) return true;
        long index = 0;
        while (index < num)
        {
            if (num == index * index) return true;
            index++;
        }
        return false;
    }
}