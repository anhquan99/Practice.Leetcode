namespace UnitTest.PrefixSuffix;

[TestClass]
public class LargestAltitudeTest : PrefixSuffixSumTest
{
    [TestMethod]
    public void Case1()
    {
        var gain = new[] { -5, 1, 5, 0, -7 };
        var expected = 1;

        var actual = _s.LargestAltitude(gain);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case2()
    {
        var gain = new[] { -4, -3, -2, -1, 4, 3, 2 };
        var expected = 0;

        var actual = _s.LargestAltitude(gain);

        Assert.AreEqual(actual, expected);
    }
}