using System.Collections.Generic;

namespace Task4.Solution.AveragingCalculators
{
    public interface IAveragingCalculator
    {
        double GetAverage(List<double> values);
    }
}
