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

        [Fact]
        public void Given_an_integer_collection_should_filter_and_return_prime_numbers_only()
        {
            // Arrange
            var numbers = new[] { 0, 2, 3, 4, 5, 7, 8, 11, 17, 99, 189 };
            var expectedResult = new[] { 2, 3, 5, 7, 11, 17 };

            // Act
            var primeNumbers = _decompositionService.GetPrimeNumbers(numbers);

            // Assert
            primeNumbers.Should().BeEquivalentTo(expectedResult);
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
