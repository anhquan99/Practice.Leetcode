using System.Text;

namespace Application
{
    public partial class HashTableSolution
    {
        public int DistinctIntegers(int n) {
            return n != 1 ? n - 1 : 1;
        }
    }
}