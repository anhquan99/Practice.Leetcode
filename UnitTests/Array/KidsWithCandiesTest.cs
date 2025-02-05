namespace UnitTest.Array;

[TestClass]
public class KidsWithCandiesTest : ArrayTest
{
    [TestMethod]
    public void Case1()
    {
        int[] candies = [2,3,5,1,3];
        int extraCandies = 3;
        bool[] result = [true,true,true,false,true];

        var actual = _s.KidsWithCandies(candies, extraCandies);

        CollectionAssert.AreEqual(actual.ToList(), result);
    }
    [TestMethod]
    public void Case2()
    {
        int[] candies = [4,2,1,1,2];
        int extraCandies = 1;
        bool[] result = [true,false,false,false,false];

        var actual = _s.KidsWithCandies(candies, extraCandies);

        CollectionAssert.AreEqual(actual.ToArray(), result);
    }
    [TestMethod]
    public void Case3()
    {
        int[] candies = [12,1,12];
        int extraCandies = 10;
        bool[] result = [true,false,true];

        var actual = _s.KidsWithCandies(candies, extraCandies);

        CollectionAssert.AreEqual(actual.ToArray(), result);
    }
}