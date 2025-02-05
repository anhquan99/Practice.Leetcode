namespace UnitTest.Array;

[TestClass]
public class SortJumbledTest : ArrayTest
{
    [TestMethod]
    public void Case1()
    {
        int[] mapping = [8, 9, 4, 0, 2, 1, 3, 5, 7, 6];
        int[] nums = [991, 338, 38];
        int[] result = [338, 38, 991];
        var actual = _s.SortJumbled(mapping, nums);
        CollectionAssert.AreEqual(actual, result);
    }
    [TestMethod]
    public void Case2()
    {
        int[] mapping = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int[] nums = [789, 456, 123];
        int[] result = [123, 456, 789];
        var actual = _s.SortJumbled(mapping, nums);
        CollectionAssert.AreEqual(actual, result);
    }
    [TestMethod]
    public void Case3()
    {
        int[] mapping = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int[] nums = [0, 999999999];
        int[] result = [0, 999999999];
        var actual = _s.SortJumbled(mapping, nums);
        CollectionAssert.AreEqual(actual, result);
    }
    [TestMethod]
    public void Case4()
    {
        int[] mapping = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];
        int[] nums = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
        int[] result = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];
        var actual = _s.SortJumbled(mapping, nums);
        CollectionAssert.AreEqual(actual, result);
    }
}