namespace Application;
public partial class QueueSolution
{
    public class ProductOfNumbers
    {
        private int[] data;
        private int index;
        public ProductOfNumbers()
        {
            data = new int[2];
            index = 0;
        }

        public void Add(int num)
        {
            data[index] = num;
            index++;
            if (index == data.Length)
            {
                var newData = new int[data.Length * 2];
                for (int i = 0; i < index; i++)
                {
                    newData[i] = data[i];
                }
                data = newData;
            }
        }

        public int GetProduct(int k)
        {
            var result = 1;
            for (int i = index - 1; i > index - k - 1; i--)
            {
                result *= data[i];
            }
            return result;
        }
    }
}