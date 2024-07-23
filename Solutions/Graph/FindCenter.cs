namespace Application;

public partial class GraphSolution
{
    public int FindCenter(int[][] edges)
    {
        var dic = new Dictionary<int, int>();
        foreach (var i in edges)
        {
            if (dic.ContainsKey(i[0]))
            {
                dic[i[0]]++;
            }
            else
            {
                dic.Add(i[0], 1);
            }
            if (dic.ContainsKey(i[1]))
            {
                dic[i[1]]++;
            }
            else
            {
                dic.Add(i[1], 1);
            }
        }
        return dic.Where(x => x.Value == edges.Length).Select(x => x.Key).FirstOrDefault();
    }
}