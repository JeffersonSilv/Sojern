namespace Math.Models
{
    public record MaxRequestViewModel
    {
        public MaxRequestViewModel(IEnumerable<double> numbers, int quantifier)
        {
            Numbers = numbers;
            Quantifier = quantifier;
        }

        public IEnumerable<double> Numbers { get; }

        public int Quantifier { get; }
    }
}