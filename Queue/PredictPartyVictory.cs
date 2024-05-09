using System.Text;

namespace Application;
public partial class QueueSolution
{
    int dPower;
    List<int> dIndex;
    int rPower;
    List<int> rIndex;
    public string PredictPartyVictory(string senate)
    {
        var cpSenate = senate.ToLower();

        while (cpSenate.Length > 1)
        {
            dPower = 0; rPower = 0;
            dIndex = new List<int>(); rIndex = new List<int>();
            var indexToBeRemove = new List<int>();
            for (int i = 0; i < cpSenate.Length - 1; i++)
            {
                Ban(cpSenate, i, indexToBeRemove);
            }
            BanLastIndex(cpSenate, indexToBeRemove);
            BanRemain(indexToBeRemove);
            var sb = new StringBuilder();
            var allSenateSame = true;
            char checkSenate = 'e';
            for (int i = 0; i < cpSenate.Length; i++)
            {
                if (!indexToBeRemove.Contains(i))
                {
                    if (checkSenate == 'e')
                    {
                        checkSenate = cpSenate[i];
                    }
                    else if (checkSenate != cpSenate[i])
                    {
                        allSenateSame = false;
                    }
                    sb.Append(cpSenate[i]);

                }
            }
            cpSenate = sb.ToString();
            if (allSenateSame)
            {
                return sb[0] == 'd' ? "Dire" : "Radiant";
            }
        }
        return cpSenate[0] == 'd' ? "Dire" : "Radiant";
    }
    private void Ban(string cpSenate, int i, List<int> indexToBeRemove)
    {
        if (cpSenate[i] == 'd')
        {
            if (rPower == 0)
            {
                dPower++;
                dIndex.Add(i);
            }
            else
            {
                rPower--;
                indexToBeRemove.Add(i);
            }
        }
        if (cpSenate[i] == 'r')
        {
            if (dPower == 0)
            {
                rIndex.Add(i);
                rPower++;
            }
            else
            {
                dPower--;
                indexToBeRemove.Add(i);
            }
        }
    }
    private void BanLastIndex(string cpSenate, List<int> indexToBeRemove)
    {
        var lastIndex = cpSenate.Length - 1;
        if (cpSenate[lastIndex] == 'd')
        {
            if (rPower > 0)
            {
                indexToBeRemove.Add(lastIndex);
                rPower--;
                return;
            }
            var firstIndexOfR = rIndex.Count > 0 ? rIndex[0] : -1;
            if (firstIndexOfR != -1)
            {
                indexToBeRemove.Add(firstIndexOfR);
                rIndex.RemoveAt(0);
            }
        }
        else
        {
            if (dPower > 0)
            {
                indexToBeRemove.Add(lastIndex);
                dPower--;
                return;
            }
            var firstIndexOfD = dIndex.Count > 0 ? dIndex[0] : -1;
            if (firstIndexOfD != -1)
            {
                indexToBeRemove.Add(firstIndexOfD);
                dIndex.RemoveAt(0);
            }
        }

    }
    private void BanRemain(List<int> indexToBeRemove)
    {
        while (rPower > 0 && dIndex.Count > 0)
        {
            var tmp = dIndex[0];
            indexToBeRemove.Add(tmp);
            dIndex.RemoveAt(0);
            rPower--;
        }
        while (dPower > 0 && rIndex.Count > 0)
        {
            var tmp = rIndex[0];
            indexToBeRemove.Add(tmp);
            rIndex.RemoveAt(0);
            dPower--;
        }
    }
}