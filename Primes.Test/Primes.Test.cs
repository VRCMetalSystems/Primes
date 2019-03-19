using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Primes;

namespace Primes.Test
{
    [TestClass]
    public class PrimesTester
    {
        [TestInitialize]
        public void PrimesInitialize()
        {
            // Not needed as Primes is a Static Class
        }

        [TestMethod]
        public void GivenAValueOfOne_TheExpectedResultIsAnEmptyList()
        {
            // Arrange - Setup the values for the function
            var One = 1;
            var empty = new List<int>();

            // Act - Perform an operation
            var result = Primes.FindPrimes(One);

            // Assert - Check for validity
            Assert.IsTrue(empty.Count == result.Count);
        }
    }
}
