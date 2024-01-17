using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllergyRanker.Models;

namespace AllergyRankerTests
  {
    [TestClass]
    public class AllergyCalculatorTests
    {
      [TestMethod]
      public void ReturnScore_ReturnsANumber_Int()
      {
        Assert.AreEqual(int,AllergyCalculator.ReturnScore());
      }
      
    }
  }