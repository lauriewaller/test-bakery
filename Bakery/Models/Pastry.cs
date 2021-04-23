namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int SalePrice { get; set; }

    public Pastry()
    {
      Price = 2;
    }

    public int DeterminePastryPrice(int pastryNumber)
    {
      if ((pastryNumber % 3) == 0)
      {
        int salePrice = DetermineSalePrice(pastryNumber);
        return salePrice;
      }
      else
      {
        return pastryNumber * Price;
      }
    }

    public int DetermineSalePrice(int pastryNumber)
    {
        int threeDivisor = pastryNumber / 3;
        return threeDivisor * 5;
    }

  }
}
// Bread: Buy 2, get 1 free. A single loaf costs $5.
// Pastry: Buy 1 for \$2 or 3 for $5.
// using System.Collections.Generic;
