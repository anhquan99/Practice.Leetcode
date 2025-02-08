namespace UnitTest.PrefixSuffix;

[TestClass]
public class PivotIndexTest : PrefixSuffixSumTest
{
    [TestMethod]
    public void Case1()
    {
        int[] nums = [1, 7, 3, 6, 5, 6];
        var expected = 3;

        var actual = _s.PivotIndex(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case2()
    {
        int[] nums = [1, 2, 3];
        var expected = -1;

        var actual = _s.PivotIndex(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case3()
    {
        int[] nums = [2, 1, -1];
        var expected = 0;

        var actual = _s.PivotIndex(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case4()
    {
        int[] nums = [1, 1];
        var expected = -1;

        var actual = _s.PivotIndex(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case5()
    {
        int[] nums = [1, 1, 1, 1];
        var expected = -1;

        var actual = _s.PivotIndex(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case6()
    {
        int[] nums = [1, 1, 1];
        var expected = 1;

        var actual = _s.PivotIndex(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case7()
    {
        int[] nums = [-1, -1, 0, 0, -1, -1];
        var expected = 2;

        var actual = _s.PivotIndex(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case8()
    {
        int[] nums = [-1, -1, 0, -1, -1, -1];
        var expected = 3;

        var actual = _s.PivotIndex(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case9()
    {
        int[] nums = [-1, -1, 0, 1, -1, -1];
        var expected = 1;

        var actual = _s.PivotIndex(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case10()
    {
        int[] nums = [0, -1, -1, 0, 1, 1];
        var expected = 0;

        var actual = _s.PivotIndex(nums);

        Assert.AreEqual(actual, expected);
    }
}