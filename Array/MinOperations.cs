namespace Application;

public partial class ArraySolution
{
    public int MinOperations(string[] logs)
    {
        int result = 0;
        foreach (string log in logs)
        {
            switch (log)
            {
                case "../":
                    result = result - 1 > 0 ? result - 1 : 0;
                    break;
                case "./":
                    break;
                default:
                    result++;
                    break;
            }
        }
        return result;
    }
}