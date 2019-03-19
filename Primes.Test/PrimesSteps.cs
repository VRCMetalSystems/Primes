using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Primes;
using NUnit.Framework;

namespace Primes.Test
{
    [Binding]
    public class PrimesSteps
    {
        [Given(@"I have entered one as N")]
        public void GivenIHaveEnteredOneAsN()
        {
            ScenarioContext.Current.Add("One", 1);
        }

        [When(@"I execute findPrimes with value one")]
        public void WhenIExecuteFindPrimesWithValueOne()
        {
            var One = (int)ScenarioContext.Current["One"];
            var primes = Primes.FindPrimes(One);
            ScenarioContext.Current.Add("Result", primes);
        }

        [Then(@"the result should be an empty list")]
        public void ThenTheResultShouldBeAnEmptyList()
        {
            var primes = ScenarioContext.Current["Result"] as List<int>;

            Assert.AreEqual(new List<int>(), primes);
        }
    }
}
