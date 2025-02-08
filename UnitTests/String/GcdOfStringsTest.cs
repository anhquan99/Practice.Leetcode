namespace UnitTest.String;

[TestClass]
public class GcdOfStringsTest : StringTest
{
    [TestMethod]
    public void Case1()
    {
        string str1 = "ABCABC", str2 = "ABC";
        var expected = "ABC";

        var actual = _s.GcdOfStrings(str1, str2);

        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Case2()
    {
        string str1 = "ABABAB", str2 = "ABAB";
        var expected = "AB";

        var actual = _s.GcdOfStrings(str1, str2);

        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Case3()
    {
        string str1 = "LEET", str2 = "CODE";
        var expected = "";

        var actual = _s.GcdOfStrings(str1, str2);

        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Case4()
    {
        string str1 = "ABABABAB", str2 = "ABAB";
        var expected = "ABAB";

        var actual = _s.GcdOfStrings(str1, str2);

        Assert.AreEqual(expected, actual);
    }
}