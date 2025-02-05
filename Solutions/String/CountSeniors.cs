using System.Text;

namespace Application;
public partial class StringSolution
{
    public int CountSeniors(string[] details) {
        int reuslt = 0;
        foreach (var i in details)
        {
            if (int.Parse(i.Substring(i.Length - 4, 2)) > 60) reuslt++;
        }
        return reuslt;
    }
}