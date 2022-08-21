namespace Math.Models
{
    public record MedianRequestViewModel
    {
        public IEnumerable<double> Numbers { get; }

        public MedianRequestViewModel(IEnumerable<double> numbers)
        {
            Numbers = numbers;
        }
    }
}