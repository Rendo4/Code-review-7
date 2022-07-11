using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void isBreadPriceRead()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(3, newBread.Ordered);
      newBread.SetPrice();
      Assert.AreEqual(10, newBread.Price);
    }
     [TestMethod]
    public void isBreadPricLooping()
    {
      Bread newBread = new Bread(7);
      newBread.SetPrice();
      Assert.AreEqual(25, newBread.Price);
    }
  }
  [TestClass]
  public class PastryTests
  {
  [TestMethod]
  public void isPastryPriceRead()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(6, newPastry.Ordered);
      newPastry.SetPrice();
      Assert.AreEqual(10, newPastry.Price);
    }
     [TestMethod]
    public void isPastryPriceLooping()
    {
      Pastry newPastry = new Pastry(10);
      newPastry.SetPrice();
      Assert.AreEqual(17, newPastry.Price);
    }
  }
}