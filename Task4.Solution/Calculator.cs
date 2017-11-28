using System;
using System.Collections.Generic;
using Task4.Solution.AveragingCalculators;

namespace Task4.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, Func<List<double>, double> averagingFunction)
        {
            if (averagingFunction == null)
            {
                throw new ArgumentNullException($"{nameof(averagingFunction)} cannot be null.");
            }

            return averagingFunction(values);
        }

        public double CalculateAverage(List<double> values, IAveragingCalculator averagingCalculator)
        {
            if (averagingCalculator == null)
            {
                throw new ArgumentNullException($"{nameof(averagingCalculator)} cannot be null.");
            }

            return averagingCalculator.GetAverage(values);
        }
    }
}
