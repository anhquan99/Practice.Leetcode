namespace UnitTest.Search;

[TestClass]
public class GuessNumberTest : SearchTest
{
    [TestMethod]
    public void Case1()
    {
        int n = 10, pick = 6;
        _s.SetPicked(pick);
        var expected = pick;

        var actual = _s.GuessNumber(n);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case2()
    {
        int n = 1, pick = 1;
        _s.SetPicked(pick);
        var expected = pick;

        var actual = _s.GuessNumber(n);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case3()
    {
        int n = 2, pick = 1;
        _s.SetPicked(pick);
        var expected = pick;

        var actual = _s.GuessNumber(n);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case4()
    {
        int n = 2, pick = 2;
        _s.SetPicked(pick);
        var expected = pick;

        var actual = _s.GuessNumber(n);

        Assert.AreEqual(actual, expected);
    }
}