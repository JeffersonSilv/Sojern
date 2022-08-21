namespace Math.Models
{
    public record PercentileRequestViewModel
    {
        public IEnumerable<double> Numbers { get; }
        public int Quantifier { get; }

        public PercentileRequestViewModel(IEnumerable<double> numbers, int quantifier)
        {
            Numbers = numbers;
            Quantifier = quantifier;
        }
    }
}