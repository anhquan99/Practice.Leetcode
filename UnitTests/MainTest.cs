using Application;

namespace UnitTest;

[TestClass]
public class MainTest
{
    [TestMethod]
    public void TestSolution()
    {
        string[] example = ["o", "cfy", "en"];
        int[] groups = [1, 0, 0];
        string[] result = ["e", "b"];
        var s = new Solution();
        var actual = s.FrequencySort([-1, 1, -6, 4, 5, -6, 1, 4, 1]);
        Assert.AreEqual(actual, [5, -1, 4, 4, -6, -6, 1, 1, 1]);
    }
}