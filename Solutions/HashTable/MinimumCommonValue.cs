namespace Application
{
    public partial class HashTableSolution
    {
        public int GetCommon(int[] nums1, int[] nums2)
        {
            var largeIndex = 0;
            var smallArr = nums1.Length > nums2.Length ? nums2 : nums1;
            var largeArr = nums1.Length > nums2.Length ? nums1 : nums2;
            for (int i = 0; i < smallArr.Length; i++)
            {
                for (; largeIndex < largeArr.Length - 1 && largeArr[largeIndex] < smallArr[i];)
                {
                    largeIndex++;
                }
                if (smallArr[i] == largeArr[largeIndex])
                {
                    return smallArr[i];
                }

            }
            return -1;
        }
    }
}