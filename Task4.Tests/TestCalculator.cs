using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Task4.Solution;
using Task4.Solution.AveragingCalculators;

namespace Task4.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, list => list.Sum() / list.Count);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, new MedianAveragingCalculator());

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}