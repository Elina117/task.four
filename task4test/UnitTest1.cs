using SquareRoot;

namespace task4test;


[TestClass]
public class Task4Test
{
    
    [TestMethod]
    public void TestMethod1()
    {
        double a = 1;
        double b = 6;
        double c = 5;

        double[] expected = { -1, -5 };

        double[] actual = SquareRootCalculator.solveSquareRoot(a, b, c);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        double a = 1;
        double b = 2;
        double c = 1;

        double[] expected = { -1 };

        double[] actual = SquareRootCalculator.solveSquareRoot(a, b, c);

        CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod3()
    {
        double a = 1;
        double b = 0;
        double c = -4;

        double[] expected = { 2, -2 };

        double[] actual = SquareRootCalculator.solveSquareRoot(a, b, c);

        CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod4()
    {
        double a = 1;
        double b = 4;
        double c = 4;

        double[] expected = { -2 };

        double[] actual = SquareRootCalculator.solveSquareRoot(a, b, c);

        CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod5()
    {
        double a = 5;
        double b = 1;
        double c = 4;

        double[] expected = { };

        double[] actual = SquareRootCalculator.solveSquareRoot(a, b, c);

        CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestMethod6()
    {
        double a = 1;
        double b = 3;
        double c = -70;

        double[] expected = { 7, -10};

        double[] actual = SquareRootCalculator.solveSquareRoot(a, b, c);

        CollectionAssert.AreEqual(expected, actual);
    }
}
