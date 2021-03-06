﻿using System;
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
            Assert.IsTrue(empty.Count.Equals(result.Count) && empty.Count is 0);
        }

        [TestMethod]
        public void GivenAValueOfTwo_TheExpectedResultIsAListContainingOnlyTwo()
        {
            var Two = 2;

            var result = Primes.FindPrimes(Two);

            Assert.IsTrue(result[0] is 2);
        }

        [TestMethod]
        public void GivenAValueOfThree_TheExpectedResultIsAListContainingOnlyTwoAndThree()
        {
            var Three = 3;

            var result = Primes.FindPrimes(Three);

            Assert.IsTrue(result[0] is 2 && result[1] is 3);
        }

        [TestMethod]
        public void GivenAValueOfTen_TheExpectedResultIsAListOfTwoThreeFiveSeven()
        {
            var value = 10;

            var result = Primes.FindPrimes(value);

            Assert.IsTrue(
                result[0] is 2 &&
                result[1] is 3 &&
                result[2] is 5 &&
                result[3] is 7);
        }

        [TestMethod]
        public void GivenAValueOfThirteen_TheExpectedResultIsAListOfPrimesUpToAndIncludingThirteen()
        {
            var value = 13;

            var result = Primes.FindPrimes(value);

            Assert.IsTrue(
                result[0] is 2 &&
                result[1] is 3 &&
                result[2] is 5 &&
                result[3] is 7 &&
                result[4] is 11 &&
                result[5] is 13);
        }
    }
}
