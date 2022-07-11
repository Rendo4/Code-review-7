using System;

namespace Bakery
{
  public class Bread
  {
    public int Ordered { get; set; }
    public int Price { get; set; }
    
    public Bread(int loaves)
    {
      Ordered = loaves;
      Price = 0;
    }
    public void SetPrice() 
    {
      if ( Ordered - 3 >= 0 )
      {
        Ordered = Ordered - 3;
        Price += 10;
        if (Ordered > 0)
        {
          SetPrice();
        }
      }
      if ( Ordered - 2 >= 0)
      {
        Ordered = Ordered - 2;
        Price += 10;
        if (Ordered > 0)
        {
          SetPrice();
        }
      }
      if (Ordered - 1 >= 0)
      {
        Ordered = -1;
        Price += 5;
      }
    }
  }
}