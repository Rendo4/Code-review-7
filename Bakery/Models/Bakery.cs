using System;

namespace Bakery
{
  public class Bread
  {
    private int _ordered;
    private int _price;
    
    public Bread(int loaves)
    {
      _ordered = loaves;
      _price = 0;
    }
    public int getLoaves()
    {
      return _ordered;
    }
    public int getPrice()
    {
      return _price;
    }
    public void SetPrice() 
    {
      if (_ordered - 3 >= 0 )
      {
        _ordered = _ordered - 3;
        _price += 10;
        if (_ordered > 0)
        {
          SetPrice();
        }
      }
      if ( _ordered - 2 >= 0)
      {
        _ordered = _ordered - 2;
        _price += 10;
        if (_ordered > 0)
        {
          SetPrice();
        }
      }
      if (_ordered - 1 >= 0)
      {
        _ordered = -1;
        _price += 5;
      }
    }
  }
  public class Pastry
  {
     private int _ordered;
    private int _price;
    
    public Pastry(int pastries)
    {
      _ordered = pastries;
      _price = 0;
    }
    public int getPastries()
    {
      return _ordered;
    }
    public int getPrice()
    {
      return _price;
    }
    public void SetPrice()
    {
      if ( _ordered >= 6)
      {
        _ordered -= 6;
        _price += 10;
        if (_ordered > 0)
        {
          SetPrice();
        }
      }
      if ( _ordered >= 5)
      {
        _ordered -= 5;
        _price += 9;
        if (_ordered > 0)
        {
          SetPrice();
        }
      }
       if ( _ordered >= 4)
      {
        _ordered -= 4;
        _price += 7;
        if (_ordered > 0)
        {
          SetPrice();
        }
      }
       if ( _ordered >= 3)
      {
        _ordered -= 3;
        _price += 5;
        if (_ordered > 0)
        {
          SetPrice();
        }
      }
       if ( _ordered >= 2)
      {
        _ordered -= 2;
        _price += 3;
        if (_ordered > 0)
        {
          SetPrice();
        }
      }
       if ( _ordered >= 1)
      {
        _ordered -= 1;
        _price += 2;
      }
    }
  }
}