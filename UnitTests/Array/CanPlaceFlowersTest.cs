namespace UnitTest.Array;

[TestClass]
public class CanPlaceFlowers : ArrayTest
{
    [TestMethod]
    public void Case1()
    {
        int[] flowerbed = [1, 0, 0, 0, 1];
        int n = 1;
        bool expected = true;

        var actual = _s.CanPlaceFlowers(flowerbed, n);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case2()
    {
        int[] flowerbed = [1, 0, 0, 0, 1];
        int n = 2;
        bool expected = false;

        var actual = _s.CanPlaceFlowers(flowerbed, n);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case3()
    {
        int[] flowerbed = [1, 0, 0, 0, 0, 1];
        int n = 2;
        bool expected = false;

        var actual = _s.CanPlaceFlowers(flowerbed, n);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case4()
    {
        int[] flowerbed = [1, 0, 0, 0, 1, 0, 0];
        int n = 2;
        bool expected = true;

        var actual = _s.CanPlaceFlowers(flowerbed, n);

        Assert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case5()
    {
        int[] flowerbed = [0, 1, 0, 0, 0, 0];
        int n = 2;
        bool expected = true;

        var actual = _s.CanPlaceFlowers(flowerbed, n);

        Assert.AreEqual(actual, expected);
    }
}