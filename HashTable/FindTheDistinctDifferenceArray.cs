using System.Text;

namespace Application
{
    public class HashTableSolution
    {
        public int[] DistinctDifferenceArray(int[] nums)
        {
            var head = new Dictionary<int, int>();
            var tail = new HashSet<int>();
            foreach (var i in nums)
            {
                if (!head.ContainsKey(i))
                {
                    head.Add(i, 1);
                }
                else
                {
                    head[i]++;
                }
            }
            var result = new List<int>();
            foreach (var i in nums)
            {
                tail.Add(i);
                head[i]--;
                if (head[i] == 0)
                {
                    head.Remove(i);
                }
                result.Add(tail.Count - head.Count);
            }
            GC.Collect();
            return result.ToArray();
        }
        public int MinimizedStringLength(string s)
        {
            var hs = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                hs.Add(s[i]);
            }
            return hs.Count;
        }
        public bool IsFascinating(int n)
        {
            var result = new int[10];
            var uniqueNumbers = 0;
            for (int i = 1; i <= 3; i++)
            {
                var temp = i * n;
                while (temp > 0)
                {
                    var number = temp % 10;
                    temp /= 10;
                    if (number == 0 || ++result[number] > 1) return false;
                    uniqueNumbers++;
                }
            }
            return uniqueNumbers == 9;
        }
        public int MaximumNumberOfStringPairs(string[] words)
        {
            var hs = new HashSet<string>();
            var result = 0;
            foreach (var i in words)
            {
                var reverse = new string(new char[] { i[1], i[0] });
                if (!hs.Contains(i) && !hs.Contains(reverse))
                {
                    hs.Add(i);
                }
                else
                {
                    result++;
                }
            }
            return result;
        }
        public bool IsGood(int[] nums)
        {
            var max = nums.Max();
            if (max + 1 != nums.Length) return false;
            var result = new bool[max + 2];
            var numCount = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max) continue;
                if (result[nums[i]])
                {
                    return false;
                }
                result[nums[i]] = true;
                numCount++;
            }
            return numCount == max;
        }
        public int MaxSum(int[] nums)
        {
            var dic = new Dictionary<int, List<int>>();
            foreach (var i in nums)
            {
                int max = int.MinValue;
                var temp = i;
                while (temp > 0)
                {
                    var div = temp % 10;
                    temp /= 10;
                    if (max < div)
                    {
                        max = div;
                    }
                }
                if (!dic.ContainsKey(max))
                {
                    dic.Add(max, new List<int>() { i });
                }
                else
                {
                    dic[max].Add(i);
                }
            }
            var result = -1;
            foreach (var i in dic.Where(x => x.Value.Count > 1).Select(x => x))
            {
                i.Value.Sort();
                i.Value.ForEach(x => { Console.Write("{0} ", x); });
                Console.WriteLine(); var tempMax = i.Value[i.Value.Count - 1] + i.Value[i.Value.Count - 2];
                result = tempMax > result ? tempMax : result;
            }
            return result;
        }
    }
}