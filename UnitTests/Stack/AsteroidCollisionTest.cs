namespace UnitTest.Stack;

[TestClass]
public class AsteroidCollisionTest : StackTest
{
    [TestMethod]
    public void Case1()
    {
        var asteroids = new[] { 5, 10, -5 };
        var expected = new[] { 5, 10 };

        var actual = _s.AsteroidCollision(asteroids);

        CollectionAssert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case2()
    {
        var asteroids = new[] { 8, -8 };
        var expected = new int[0];

        var actual = _s.AsteroidCollision(asteroids);

        CollectionAssert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case3()
    {
        var asteroids = new[] { 10, 2, -5 };
        var expected = new int[] { 10 };

        var actual = _s.AsteroidCollision(asteroids);

        CollectionAssert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case4()
    {
        var asteroids = new[] { -2, -1, 1, 2 };
        var expected = new int[] { -2, -1, 1, 2 };

        var actual = _s.AsteroidCollision(asteroids);

        CollectionAssert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case5()
    {
        var asteroids = new[] { -2, -2, -2, -2 };
        var expected = new int[] { -2, -2, -2, -2 };

        var actual = _s.AsteroidCollision(asteroids);

        CollectionAssert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case6()
    {
        var asteroids = new[] { -2, -2, 1, -2 };
        var expected = new int[] { -2, -2, -2 };

        var actual = _s.AsteroidCollision(asteroids);

        CollectionAssert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case7()
    {
        var asteroids = new[] { -2, 1, -2, 1 };
        var expected = new int[] { -2, -2, 1 };

        var actual = _s.AsteroidCollision(asteroids);

        CollectionAssert.AreEqual(actual, expected);
    }
    [TestMethod]
    public void Case8()
    {
        var asteroids = new[] { 1, -2, 1, -1 };
        var expected = new int[] { -2 };

        var actual = _s.AsteroidCollision(asteroids);

        CollectionAssert.AreEqual(actual, expected);
    }
}