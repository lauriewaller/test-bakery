namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int SalePrice { get; set; }

    public Bread()
    {
      Price = 5;
    }

    public int DetermineBreadPrice(int breadNumber)
    {
      if ((breadNumber % 3) == 0)
      {
        int salePrice = DetermineSalePrice(breadNumber);
        return salePrice;
      }
      else
      {
        return breadNumber * Price;
      }
    }

    public int DetermineSalePrice(int breadNumber)
    {
      int threeDivisor = breadNumber / 3;
      return (breadNumber * Price) - (threeDivisor * Price);
    }
    
  }
}

// Bread: Buy 2, get 1 free. A single loaf costs $5.
// Pastry: Buy 1 for $2 or 3 for $5.
// using System.Collections.Generic;
// can have a separate method for discount so that it's easier to refactor in the future 