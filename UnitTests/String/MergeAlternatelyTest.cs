namespace UnitTest.String;

[TestClass]
public class MergeAlternatelyTest : StringTest
{
    [TestMethod]
    public void Case1()
    {
        var word1 = "abc";
        var word2 = "pqr";
        var result = "apbqcr";

        var actual = _s.MergeAlternately(word1, word2);

        Assert.AreEqual(result, actual);
    }
    [TestMethod]
    public void Case2()
    {
        var word1 = "ab";
        var word2 = "pqrs";
        var result = "apbqrs";

        var actual = _s.MergeAlternately(word1, word2);

        Assert.AreEqual(result, actual);
    }
    public void Case3()
    {
        var word1 = "abcd";
        var word2 = "pq";
        var result = "apbqcd";

        var actual = _s.MergeAlternately(word1, word2);

        Assert.AreEqual(result, actual);
    }
}