namespace Application;
public partial class HeapSolution
{
    public string[] FindRelativeRanks(int[] score)
    {
        var cpScore = new int[score.Length];
        Array.Copy(score, cpScore, score.Length);
        Array.Sort(cpScore, (a, b) => b.CompareTo(a));
        var dic = new Dictionary<int, string>();
        var index = 0;
        foreach (var scoreItem in cpScore)
        {
            var title = string.Empty;
            switch (index)
            {
                case 0:
                    title = "Gold Medal";
                    break;
                case 1:
                    title = "Silver Medal";
                    break;
                case 2:
                    title = "Bronze Medal";
                    break;
                default:
                    title = (index + 1).ToString();
                    break;
            }
            dic.Add(scoreItem, title);
            index++;
        }
        var result = new string[score.Length];
        for (int i = 0; i < score.Length; i++)
        {
            result[i] = dic[score[i]];
        }
        return result;
    }
}