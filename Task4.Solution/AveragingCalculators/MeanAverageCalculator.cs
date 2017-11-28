using System.Collections.Generic;
using System.Linq;

namespace Task4.Solution.AveragingCalculators
{
    public class MeanAverageCalculator : IAveragingCalculator
    {
        public double GetAverage(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
