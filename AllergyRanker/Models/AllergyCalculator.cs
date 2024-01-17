using System.Collections.Generic;

namespace AllergyRanker.Models
{
  public class AllergyCalculator
  {
    private static Dictionary<string, int> allergenGuide = new Dictionary<string, int>() { { "cats", 128 }, { "pollen", 64 }, { "chocolate", 32 }, { "tomatoes", 16 }, { "strawberries", 8 }, { "shellfish", 4 }, { "peanuts", 2 }, { "eggs", 1 } };

    public static string[] GetAllergens(int inputNumber)
    {
      List<string> allergies = new List<string>();
      foreach (KeyValuePair<string, int> entry in allergenGuide)
      {
        if ((inputNumber & allergenGuide[entry.Key]) != 0)
        {
          allergies.Add(entry.Key);
        }
      }
      return allergies.ToArray();
    }
  }
}

// create an array of allergy values from largest to smallest
// allergy array = [128,64,32,16,8,4,2,1]
// another array = [cats, pollen, chocolate, tomatoes, strawberies, shellfish, peanuts, eggs]
// if value at (i) <=  current allegy score then subtract value at index from current allergy score;
// forEach(allergyarray) 
// {
//   if  currentAllergy >= allergyarray 
//   current allergy - allergyarray
//   make some note that we did this operation
//   make a list push these values from another array
//   [1,1,0,0,1,1,0,1]
// }

// return list

// 200 - 128 = 72 -> >= 0 so we add this to our allergies as an actual allergy
// 72 -64 = 8
// 8 - 32 = -24 -> !>= 0 so we skip
// 8 - 8 = 0
// output = (cats, pollen, strawberries)
// The plan



// my idea

// cats, pollen, chocolate, tomatoes, strawberies, shellfish, peanuts, eggs
//  -> 1011 1010
// 1(index) * 2^n
// */

//RECURSIVE ATTEMPT BELOW

// List<string> allergies = new List<string>();
// foreach (KeyValuePair<string, int> entry in allergenGuide)
// if (inputNumber & allergenGuide[entry]) != 0)
//  allergies.Add(entry)
// return allergies

// public static string[] returnAllergens(int inputNumber)
// {
//   int allergyScore = inputNumber;
//   List<string> allergenList = new List<string> { };
//   for (int i = 0; i < allergenGuide.Count; i++)
//   {
//     KeyValuePair<string, int> entry = allergenGuide.ElementAt(i);
//     if (allergyScore == 0)
//     {
//       string[] allergenResults = allergenList.ToArray();
//       Console.WriteLine("You're in the if");
//       Console.WriteLine(allergenResults);
//       return allergenResults;
//     }
//     else if (entry.Value <= allergyScore)
//     {
//       allergenList.Add(entry.Key);
//       allergyScore -= entry.Value;
//       string[] remainingAllergens = returnAllergens(allergyScore);
//         allergenList.AddRange(remainingAllergens);

//         Console.WriteLine("You're in the else if");
//         Console.WriteLine(string.Join(", ", allergenList));
//         Console.WriteLine(allergyScore);
//         break;
//     }
//   }

//   Console.WriteLine("You're outside of the loop");
//   return allergenList.ToArray();
// }