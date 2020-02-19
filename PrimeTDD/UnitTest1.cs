using System;
using Xunit;
using Lab_4_3;

namespace PrimeTDD
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]
        [InlineData(8, 19)]
        [InlineData(9, 23)]
        [InlineData(10, 29)]
        [InlineData(107, 587)]
        public void TestPrime(int a, long expected)
        {
            PrimeNumbers.MakePrimeList();
            // Arrange and Act
            int result = PrimeNumbers.GetPrime(a);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
