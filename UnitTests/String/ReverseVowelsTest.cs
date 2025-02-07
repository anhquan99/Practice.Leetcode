namespace UnitTest.String;

[TestClass]
public class ReverseVowelsTest : StringTest
{
    [TestMethod]
    public void Case1()
    {
        var s = "IceCreAm";
        var expected = "AceCreIm";

        var actual = _s.ReverseVowels(s);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case2()
    {
        var s = "leetcode";
        var expected = "leotcede";

        var actual = _s.ReverseVowels(s);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case3()
    {
        var s = "a1e2i";
        var expected = "i1e2a";

        var actual = _s.ReverseVowels(s);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case4()
    {
        var s = "a123e2i";
        var expected = "i123e2a";

        var actual = _s.ReverseVowels(s);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case5()
    {
        var s = "Ui";
        var expected = "iU";

        var actual = _s.ReverseVowels(s);

        Assert.AreEqual(actual, expected);
    }
}