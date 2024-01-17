using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllergyRanker.Models;

namespace AllergyRankerTests
{
  [TestClass]
  public class AllergyCalculatorTests
  {
    [TestMethod]
    public void returnAllergens_ReturnsAnArray_string()
    {
      string[] allergens = AllergyCalculator.GetAllergens(25);
      Assert.IsInstanceOfType(allergens, typeof(string[]));
    }

    [TestMethod]
    public void GetAllergens_ReturnsStrawberriesAndPeanutsIf10_string()
    {
      string[] expectedString = new string[] { "strawberries", "peanuts" };
      string[] actualString = AllergyCalculator.GetAllergens(10);
      CollectionAssert.AreEqual(expectedString, actualString);
    }

    [TestMethod]
    public void GetAllergens_ReturnsCatsIf128_string()
    {
      string[] expectedString = new string[] { "cats" };
      string[] actualString = AllergyCalculator.GetAllergens(128);
      CollectionAssert.AreEqual(expectedString, actualString);
    }

    [TestMethod]
    public void GetAllergens_ReturnsAllValuesIf255_string()
    {
      string[] expectedString = new string[] { "cats", "pollen", "chocolate", "tomatoes", "strawberries", "shellfish", "peanuts", "eggs" };
      string[] actualString = AllergyCalculator.GetAllergens(255);
      CollectionAssert.AreEqual(expectedString, actualString);
    }

    [TestMethod]
    public void GetAllergens_ReturnsAllButEggsIf254_string()
    {
      string[] expectedString = new string[] { "cats", "pollen", "chocolate", "tomatoes", "strawberries", "shellfish", "peanuts" };
      string[] actualString = AllergyCalculator.GetAllergens(254);
      CollectionAssert.AreEqual(expectedString, actualString);
    }
  }
}