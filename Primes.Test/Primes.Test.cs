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
            // Not needs as Primes is a Static Class
        }

        [TestMethod]
        public void GivenAValueOfOne_TheExpectedResultIsAnEmptyList()
        {
            // Arrange - Setup the values for the function
            var One = 1;

            // Act
            var result = Primes.FindPrimes(One);

            // Assert
            Assert.AreEqual(new List<int>(), result);
        }
    }
}
