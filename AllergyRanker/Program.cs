using System;
using System.Threading;
using AllergyRanker.Models;

class Program
{
  static void Main()
  {
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@"                                                                                                              
       db         88  88                                                    88b           d88  88888888ba,    
      d88b        88  88                                                    888b         d888  88      `'8b   
     d8'`8b       88  88                                                    88`8b       d8'88  88        `8b  
    d8'  `8b      88  88   ,adPPYba,  8b,dPPYba,   ,adPPYb,d8  8b       d8  88 `8b     d8' 88  88         88  
   d8YaaaaY8b     88  88  a8P_____88  88P'   'Y8  a8'    `Y88  `8b     d8'  88  `8b   d8'  88  88         88  
  d8''''''''8b    88  88  8PP'''''''  88          8b       88   `8b   d8'   88   `8b d8'   88  88         8P  
 d8'        `8b   88  88  '8b,   ,aa  88          '8a,   ,d88    `8b,d8'    88    `888'    88  88      .a8P   
d8'          `8b  88  88   `'Ybbd8''  88           `'YbbdP'Y8      Y88'     88     `8'     88  88888888Y''    
                                                   aa,    ,88      d8'                                        
                                                    'Y8bbdP'      d8'                                         ");
    Console.ResetColor();
    Console.WriteLine(@"
       Welcome to the 
       A L L E R G Y 
    C A L C U L A T O R™
    --------------------
    ");
    Console.WriteLine("Input the number that the allergy doctor gave you and determine which allergies you have!");
    GetNumberInput();
  }

  static void GetNumberInput()
  {
    Console.WriteLine("Please input a number (0 - 255):");
    try
    {
      int userInput = int.Parse(Console.ReadLine());
      if (userInput < 0 || userInput > 255)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Number is outside valid range (0 - 255)");
        Console.ResetColor();
        GetNumberInput();
      }
      Console.WriteLine("");
      ShowResults(userInput);
    }
    catch (Exception error)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"{error.Message} Please input a number.");
      Console.ResetColor();
      GetNumberInput();
    }
  }

  static void ShowResults(int allergenNumber)
  {
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("You are allergic to:");
    Console.WriteLine("--------------------");
    string[] results = AllergyCalculator.GetAllergens(allergenNumber);
    foreach(string entry in results)
    {
      Console.WriteLine(entry);
    }
    Console.WriteLine("");
    Console.ResetColor();
    Console.WriteLine("");
    Console.WriteLine("Sorry about that...");
    PostResults();
  }

  static void PostResults()
  {
    Console.WriteLine("");
    Console.WriteLine("Would you like to enter another number? (y/n)");
    string repeatResponse = Console.ReadLine().ToLower();
    if (repeatResponse == "y")
    {
      GetNumberInput();
    } else if (repeatResponse == "n")
    {
      Console.WriteLine("Thanks for using AllergyMD! That will be...");
      Thread.Sleep(700);
      Console.WriteLine("...");
      Thread.Sleep(700);
      Console.WriteLine("...");
      Thread.Sleep(700);
      Console.WriteLine("Carry the one...");
      Thread.Sleep(700);
      Console.WriteLine("...");
      Thread.Sleep(700);
      Console.WriteLine("...");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("$2,420.69");
      Console.ResetColor();
      Thread.Sleep(1500);
      Console.WriteLine("Goodbye!");
      
    }
    else
    {
      Console.WriteLine("Please only enter 'y' or 'n'.");
      PostResults();
    }
  }
}