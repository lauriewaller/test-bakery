using System;
using Bakery.Models;

namespace UserBakery
{
  public class BakeryProgram
  {
    public static void Main()
    {

      Bread TodayBread = new Bread();
      Pastry TodayPastry = new Pastry();

      Console.WriteLine("Welcome to Pierre's Bakery! Today we're offering sourdough bread($" + TodayBread.Price + ")" + " and a puff pastry($" + TodayPastry.Price + ").");
      Console.WriteLine("Specials Today: Buy 2 loaves of bread, get 1 free! Get 3 pastries for just $5!");
      Console.WriteLine("Enter how many loaves of sourdough bread you would like:");
      string breadEntry = Console.ReadLine();
      int breadNumber = int.Parse(breadEntry);
      Console.WriteLine("Enter how many puff pastries you would like:");
      string pastryEntry = Console.ReadLine();
      int pastryNumber = int.Parse(pastryEntry);

      int breadResult = TodayBread.DetermineBreadPrice(breadNumber);
      int pastryResult = TodayPastry.DeterminePastryPrice(pastryNumber);
      Console.WriteLine("bread: " + breadResult);
      Console.WriteLine("pastry: " + pastryResult);

      int totalCost = TodayBread.DetermineBreadPrice(breadNumber) + TodayPastry.DeterminePastryPrice(pastryNumber);

      // if (breadResult == 0)
      // {
      //   Console.WriteLine("No bread for you today!");
      // }
      
      Console.WriteLine("Your total today is $" + totalCost + ". Come back soon!");
      

    }
  }
}

// Bread: Buy 2, get 1 free. A single loaf costs $5.
// Pastry: Buy 1 for $2 or 3 for $5.
// using System.Collections.Generic;