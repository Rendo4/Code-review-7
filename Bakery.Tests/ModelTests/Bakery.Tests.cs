using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void isBreadModelMade()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(int), newBread.GetType());
    }
    [TestMethod]
    public void isBreadPriceRead()
    {
      Bread newBread = new Bread(3);
      newBread.SetPrice();
      Assert.AreEqual(10, newBread.Price);
    }
    [TestMethod]
    public void isBreadLovesRead()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(3, newBread.Ordered);
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
    public void isPastryModelMade()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(int), newPastry.GetType());
    }
    [TestMethod]
    public void isPastriesOrderedRead()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(6, newPastry.Ordered);
    }
    [TestMethod]
    public void isPastryPriceRead()
    {
      Pastry newPastry = new Pastry(6);
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