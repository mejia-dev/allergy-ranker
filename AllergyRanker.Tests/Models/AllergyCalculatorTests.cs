using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllergyRanker.Models;
using System;

namespace AllergyRankerTests
  {
    [TestClass]
    public class AllergyCalculatorTests
    {
      [TestMethod]
      public void returnAllergens_ReturnsAnArray_string()
      {
        string[] allergens = AllergyCalculator.returnAllergens(25);
        Assert.IsInstanceOfType(allergens, typeof(string[]));
      }

      
      
    }
  }