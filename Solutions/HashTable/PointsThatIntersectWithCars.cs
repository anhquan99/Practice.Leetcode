using Microsoft.VisualBasic;

namespace Application
{
    public partial class HashTableSolution
    {
        public int NumberOfPoints(List<List<int>> nums)
        {
            var dic = new Dictionary<int, int>();
            foreach (var i in nums)
            {
                if (!dic.ContainsKey(i[0]))
                {
                    dic.Add(i[0], i[1]);
                }
                else if (dic[i[0]] < i[1]) dic[i[0]] = i[1];
            }
            var list = dic.OrderBy(x => x.Key).Select(x => new List<int>() { x.Key, x.Value }).ToList();
            var index = 0;
            var result = new List<List<int>>() { list[0] };
            foreach (var i in list)
            {
                if (IsIntersect(result[index], i))
                {
                    if (i[1] > result[index][1]) result[index][1] = i[1];
                }
                else
                {
                    result.Add(i);
                    index++;
                }
            }
            var sum = 0;
            result.ForEach(x =>
            {
                sum += x[1] - x[0] + 1;
            });
            return sum;

        }
        private bool IsIntersect(List<int> examiner, List<int> examinee)
        {
            return (examinee[0] >= examiner[0] && examinee[0] <= examiner[1]) ||
                (examinee[1] >= examiner[0] && examinee[1] <= examiner[1]) ||
                (examinee[0] == examiner[0] && examinee[1] == examiner[1]);
        }
    }
}