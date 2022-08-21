namespace Math.Models
{
    public record MinRequestViewModel
    {
        public MinRequestViewModel(IEnumerable<double> numbers, int quantifier)
        {
            Numbers = numbers;
            Quantifier = quantifier;
        }

        public IEnumerable<double> Numbers { get; }


        public int Quantifier { get; }
    }
}