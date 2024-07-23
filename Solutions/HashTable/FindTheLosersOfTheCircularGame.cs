using System.Text;

namespace Application
{
    public partial class HashTableSolution
    {
        public int[] CircularGameLosers(int n, int k)
        {
            var isRecived = new bool[n];
            var index = 0;
            var turn = 1;
            while (!isRecived[index])
            {
                isRecived[index] = true;
                index = (index + turn * k) % n;
                turn++;
            }
            var result = new List<int>();
            for (int i = 0; i < isRecived.Length; i++)
            {
                if (!isRecived[i]) result.Add(i + 1);
            }
            return result.ToArray();
        }
    }
}