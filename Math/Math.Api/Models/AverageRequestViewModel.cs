namespace Math.Models
{
    public record AverageRequestViewModel
    {
        public IEnumerable<double> Numbers { get; }

        public AverageRequestViewModel(IEnumerable<double> numbers)
        {
            Numbers = numbers;
        }
    }
}