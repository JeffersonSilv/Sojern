using MathNet.Numerics.Statistics;

namespace Math.Service.Concrete
{
    public class MathOperationsService : IMathOperationsService
    {
        public double CalculateAverage(IEnumerable<double> numbers)
        {
            if (!numbers.Any())
            {
                return 0;
            }
            return numbers.Average();
        }

        public IEnumerable<double> CalculateMaxNumbers(IEnumerable<double> numbers, int quantifier)
        {
            var ordered = numbers.ToList().OrderByDescending(x => x);

            return ordered.Take(quantifier);
        }

        public double CalculateMedian(IEnumerable<double> numbers)
        {
            return numbers.Median();
        }

        public IEnumerable<double> CalculateMinNumbers(IEnumerable<double> numbers, int quantifier)
        {
            var ordered = numbers.ToList().OrderBy(x => x);

            return ordered.Take(quantifier);
        }

        public double CalculatePercentile(IEnumerable<double> numbers, int quantifier)
        {
            return numbers.Percentile(quantifier);
        }

    }
}
