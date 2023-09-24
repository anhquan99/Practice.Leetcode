namespace Application
{
    public partial class HashTableSolution
    {
        public int MinNumber(int[] nums1, int[] nums2)
        {
            var nums1List = nums1.ToList();
            nums1List.Sort();
            var nums2List = nums2.ToList();
            nums2List.Sort();
            var intersectList = nums1List.Intersect(nums2List).ToArray();
            if (intersectList.Length > 0) return intersectList[0];
            GC.Collect();
            return nums1List[0] < nums2List[0] ? nums1List[0] + (nums2List[0] * 10) : (nums1List[0] * 10) + nums2List[0];
        }
    }
}