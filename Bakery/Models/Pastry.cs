using System;

namespace Bakery
{ 
  public class Pastry
  {
    public int Ordered { get; set; }
    public int Price { get; set; }
    
    public Pastry(int pastries)
    {
      Ordered = pastries;
      Price = 0;
    }
    public void SetPrice()
    {
      if ( Ordered >= 6)
      {
        Ordered -= 6;
        Price += 10;
        if (Ordered > 0)
        {
          SetPrice();
        }
      }
      if ( Ordered >= 5)
      {
        Ordered -= 5;
        Price += 9;
        if (Ordered > 0)
        {
          SetPrice();
        }
      }
       if ( Ordered >= 4)
      {
        Ordered -= 4;
        Price += 7;
        if (Ordered > 0)
        {
          SetPrice();
        }
      }
       if ( Ordered >= 3)
      {
        Ordered -= 3;
        Price += 5;
        if (Ordered > 0)
        {
          SetPrice();
        }
      }
       if ( Ordered >= 2)
      {
        Ordered -= 2;
        Price += 3;
        if (Ordered > 0)
        {
          SetPrice();
        }
      }
       if ( Ordered >= 1)
      {
        Ordered -= 1;
        Price += 2;
      }
    }
  }
}