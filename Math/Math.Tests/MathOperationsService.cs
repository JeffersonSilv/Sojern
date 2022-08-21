using Math.Service;
using Math.Service.Concrete;
using System.Collections.Generic;
using Xunit;

namespace Math.Tests
{
    public class MathOperationsServiceTests
    {
        private readonly IMathOperationsService _sut;

        public MathOperationsServiceTests()
        {
            _sut = new MathOperationsService();
        }

        [Theory]
        [InlineData(new[] {1, 1.3, 5, 8 }, 2, new[] {1, 1.3 })]
        [InlineData(new[] { 1, 1.3, 5, 8 }, 0, new double[] {})]
        [InlineData(new[] { 1295, 1.3, 05, 66668, 333 }, 3, new[] { 05, 1.3, 333 })]
        public void ShouldCalculateTheMinNumbersBasedOfQuantifier(IEnumerable<double> numbers, int quantifier, IEnumerable<double> expectedResult)
        {
            var result = _sut.CalculateMinNumbers(numbers, quantifier);

            foreach (var item in result)
            {
                Assert.Contains(item, expectedResult);
            }            
        }

        [Theory]
        [InlineData(new[] { 1, 1.3, 5, 8 }, 2, new double[] { 8, 5})]
        [InlineData(new[] { 1, 1.3, 5, 8 }, 0, new double[] { })]
        [InlineData(new[] { 1295, 1.3, 05, 66668, 333 }, 2, new double[] { 66668, 1295 })]
        public void ShouldCalculateTheMAxNumbersBasedOfQuantifier(IEnumerable<double> numbers, int quantifier, IEnumerable<double> expectedResult)
        {
            var result = _sut.CalculateMaxNumbers(numbers, quantifier);

            foreach (var item in result)
            {
                Assert.Contains(item, expectedResult);
            }
        }

        [Theory]
        [InlineData(new double[] { 1, 1.3F, 5, 8 }, 3.824999988079071)]
        [InlineData(new double[] { 0 }, 0)]
        [InlineData(new double[] { 1295, 1.3F, 05, 66668, 333 }, 13660.459999990464)]
        [InlineData(new double[] { }, 0)]
        [InlineData(new double[] { -1, -5, -789 }, -265)]
        public void ShouldCalculateTheAvg(IEnumerable<double> numbers, double expectedResult)
        {
            var result = _sut.CalculateAverage(numbers);

            Assert.Equal(result, expectedResult);            
        }

        [Theory]
        [InlineData(new double[] { 1, 1.3F, 5, 8 }, 3.1499999761581421)]
        [InlineData(new double[] { 0 }, 0)]
        [InlineData(new double[] { 1295, 1.3F, 05, 66668, 333 }, 333)]
        [InlineData(new double[] { }, double.NaN)]
        [InlineData(new double[] { -1, -5, -789 }, -5)]
        public void ShouldCalculateTheMedian(IEnumerable<double> numbers, double expectedResult)
        {
            var result = _sut.CalculateMedian(numbers);

            Assert.Equal(result, expectedResult);
        }


        [Theory]
        [InlineData(new double[] { 1, 3, 55, 8 },50, 5.5)]
        [InlineData(new double[] {}, 0, double.NaN)]
        [InlineData(new double[] { 1295, 1.3, 05, 66668, 333 }, 10, 1.3)]
        [InlineData(new double[] { -1, -5, -789 }, 80, -1)]
        public void ShouldCalculateThePercentileBaseOnTheQuantifier(IEnumerable<double> numbers, int quantifier, double expectedResult)
        {
            var result = _sut.CalculatePercentile(numbers, quantifier);

            Assert.Equal(result, expectedResult);
        }
    }
}