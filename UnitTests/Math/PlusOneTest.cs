using Application;

namespace UnitTest.Math;

[TestClass]
public class PlusOneTest
{
    private readonly MathSolution _s;
    public PlusOneTest()
    {
        _s = new MathSolution();
    }
    [TestMethod]
    public void Case1()
    {
        int[] digits = [8, 9, 4, 0, 2, 1, 3, 5, 7, 6];
        int[] result = [1, 2, 4];
        var actual = _s.PlusOne(digits);
        CollectionAssert.AreEqual(actual, result);
    }
    [TestMethod]
    public void Case2()
    {
        int[] digits = [4, 3, 2, 1];
        int[] result = [4, 3, 2, 2];
        var actual = _s.PlusOne(digits);
        CollectionAssert.AreEqual(actual, result);
    }
    [TestMethod]
    public void Case3()
    {
        int[] digits = [9];
        int[] result = [1, 0];
        var actual = _s.PlusOne(digits);
        CollectionAssert.AreEqual(actual, result);
    }
}