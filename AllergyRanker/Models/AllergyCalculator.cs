using System.Collections.Generic;

namespace AllergyRanker.Models
{
  public class AllergyCalculator
  {
    public string Allergen {get; set;}
    public int score {get; set;}

    private static Dictionary<string, int> allergenGuide = new Dictionary<string, int>() { {"eggs", 1}, {"peanuts", 2}, {"shellfish", 4}, {"strawberries", 8}, {"tomatoes", 16}, {"chocolate", 32}, {"pollen", 64}, {"cats", 128} };

    public static string[] returnAllergens(int inputNumber)
    {
      string[] allergens = {};
      return allergens;
      //string[] allergens = new string[] {};
    }

  }

  // foreach(KeyValuePair<string, string> entry in allergenGuide)
  // {
  //   if input > entry.Value {add entry.key}
  // }

}


// public string CheckType()
//     {
//       if ((Side1 > (Side2 + _side3)) || (Side2 > (Side1 + _side3)) || (_side3 > (Side1 + Side2))) 
//       {
//         return "not a triangle";
//       } 
//       else if ((Side1 != Side2) && ((Side1 != _side3)) && ((Side2 != _side3))) 
//       {
//         return "scalene triangle";
//       }
//     }