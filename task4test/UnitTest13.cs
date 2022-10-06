using SquareRoot;
using bubblesort;
using argument;


namespace task4test;


[TestClass]
public class Task4Test
{
    //1 task
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




    // 3 task
    [TestMethod]
    public void TestMethod7()
    {
        int[] sequence = { 1, 2, 3, 4, 6, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 19 };

        int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        int[] actual = BubbleSort.BubbleSortAlgorithm(sequence);

        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestMethod8()
    {
        int[] sequence = { 1, 2, 3, 4, 6, 5, 7, 9, 8, 10, 11, 15, 13, 14, 12, 16, 17, 18, 20, 19 };

        int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        int[] actual = BubbleSort.BubbleSortAlgorithm(sequence);

        CollectionAssert.AreEqual(expected, actual);
    }

    //4 task
    //Написать метод, где в качества аргумента будет передан массив (ключевоеслово params).
    //Вывести сумму элементов массива(вернуть).
    //Вывести(ref) произведение массива.
    //Вывести(out) среднее арифметическое в массиве.
    [TestMethod]
    public void TestMethod9()
    {

        
        //variable for store ref actual multiplicity
        int actualMultiplicity = 0;
        //variable for store actual average
        int actualAverage;
        //array which needed to be counted
        int[] numbers = { 1, 2, 3, 4 };
        //call function and return sum of array
        int sum = array.sum(ref actualMultiplicity, out actualAverage, numbers);


        //when we know what we want to get, we can check it by assertions
        Assert.AreEqual(24, actualMultiplicity);
        Assert.AreEqual(2, actualAverage);
        Assert.AreEqual(10, sum);
    }

    //[TestMethod]
    //public void TestMethod10()
    //{
        
    //    int[] numbers = { 3, 4, 2, 1, 8 };

    //    int[] expected = { 18 };

    //    int[] actual = array.summa(numbers);

    //    CollectionAssert.AreEqual(expected, actual);
    //}


   
}
