namespace Math.Service
{
    public interface IMathOperationsService
    {
        IEnumerable<double> CalculateMinNumbers(IEnumerable<double> numbers, int quantifier);

        IEnumerable<double> CalculateMaxNumbers(IEnumerable<double> numbers, int quantifier);

        double CalculateAverage(IEnumerable<double> numbers);

        double CalculateMedian(IEnumerable<double> numbers);

        double CalculatePercentile(IEnumerable<double> numbers, int quantifier);
    }
}