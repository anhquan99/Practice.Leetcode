namespace UnitTest.PrefixSuffix;

[TestClass]
public class SingleNumberTest : BitManipulationTest
{
    [TestMethod]
    public void Case1()
    {
        int[] nums = [2, 2, 1];
        var expected = 1;

        var actual = _s.SingleNumber(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case2()
    {
        int[] nums = [4, 1, 2, 1, 2];
        var expected = 4;

        var actual = _s.SingleNumber(nums);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case3()
    {
        int[] nums = [1];
        var expected = 1;

        var actual = _s.SingleNumber(nums);

        Assert.AreEqual(actual, expected);
    }
}