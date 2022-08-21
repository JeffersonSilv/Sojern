using VersionManager;
using Xunit;

namespace CompareVersions.Tests
{
    public class VersionManagerTests
    {
        [Theory]
        [InlineData("0", "0", 0)]
        [InlineData("0.0", "0.1", -1)]
        [InlineData("1.0", "0.1", 1)]
        [InlineData("0", "0.1", -1)]
        [InlineData("1.2.3.4.5.6.7.8.9", "1.2.3.4.5.6.7.8", 1)]
        [InlineData("1.2.3.4.5.6.7.8.9", "3.4", -1)]
        public void EnsureThatIsGoingToCompareVersions(string version1, string version2, int expectedResult)
        {
            var result = VersionUtil.Compare(version1, version2);

            Assert.Equal(expectedResult, result);
        }
    }
}