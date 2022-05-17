using FluentAssertions;
using NumbersDecompositionApp;
using Xunit;

namespace NumbersDecompositionTests
{
    public class DecompositionServiceTests
    {
        private readonly DecompositionService _decompositionService;

        public DecompositionServiceTests()
        {
            _decompositionService = new DecompositionService();
        }

        [Theory]
        [MemberData(nameof(IsPrimeData))]
        public void Given_a_number_should_check_if_is_prime(
            int number,
            bool expectedResult)
        {
            // Arrange

            // Act
            bool result = _decompositionService.IsPrime(number);

            // Assert
            result.Should().Be(expectedResult);
        }

        public static TheoryData<int, bool> IsPrimeData()
        {
            return new TheoryData<int, bool>
            {
                { -5, false },
                { 0, false },
                { 1, false },
                { 2, true },
                { 17, true }
            };
        }
    }
}
