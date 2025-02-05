namespace UnitTest.String;

[TestClass]
public class CountSeniorsTest : StringTest
{
    [TestMethod]
    public void Case1()
    {
        string[] details = ["7868190130M7522", "5303914400F9211", "9273338290F4010"];
        var result = 2;
        var actual = _s.CountSeniors(details);
        Assert.AreEqual(result, actual);
    }
    [TestMethod]
    public void Case2()
    {
        string[] details = ["1313579440F2036", "2921522980M5644"];
        var result = 0;
        var actual = _s.CountSeniors(details);
        Assert.AreEqual(result, actual);
    }
}