using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Primes;

namespace Primes.Test
{
    [TestClass]
    public class PrimesTester
    {
        List<int> empty = new List<int>();

        [TestInitialize]
        public void PrimesInitialize()
        {
            // Not needed as Primes is a Static Class
            
        }

        [TestMethod]
        public void GivenAValueOfZero_TheExpectedResultIsAnEmptyList()
        {
            // Arrange - Setup the values for the function
            var Zero = 0;

            // Act - Perform an operation
            var result = Primes.FindPrimes(Zero);

            // Assert - Check for validity
            Assert.IsTrue(empty.Count == result.Count && empty.Count == 0);
        }

        [TestMethod]
        public void GivenAValueOfOne_TheExpectedResultIsAnEmptyList()
        {
            // Arrange - Setup the values for the function
            var One = 1;            

            // Act - Perform an operation
            var result = Primes.FindPrimes(One);

            // Assert - Check for validity
            Assert.IsTrue(empty.Count == result.Count && empty.Count == 0);
        }
    }
}
