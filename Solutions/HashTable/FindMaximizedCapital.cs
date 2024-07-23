namespace Application;
public partial class HashTableSolution
{
    class IPO : IComparable<IPO>
    {
        public int Capital { get; set; }
        public int Profit { get; set; }
        public int CompareTo(IPO obj)
        {
            return obj.Capital.CompareTo(this.Capital) + obj.Profit.CompareTo(this.Profit);
        }
        public override string ToString()
        {
            return $"{Capital} {Profit}";
        }
    }
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
    {
        var queue = new PriorityQueue<int, IPO>();
        var dic = new Dictionary<int, List<int>>();
        for (int i = 0; i < capital.Length; i++)
        {
            if (dic.ContainsKey(capital[i]))
            {
                dic[capital[i]].Add(profits[i]);
            }
            else
            {
                dic.Add(capital[i], new List<int> { profits[i] });
            }
        }
        for (int i = 0; i < k; i++)
        {
            var capList = dic.Where(x => w >= x.Key);
            if (capList.Any())
            {
                foreach (var item in capList)
                {
                    item.Value.ForEach(x => queue.Enqueue(x, new IPO
                    {
                        Capital = item.Key,
                        Profit = x
                    }));
                    dic.Remove(item.Key); ;
                }
            }
            if (queue.Count == 0) return w;
            w += queue.Dequeue();
        }
        return w;
    }
}