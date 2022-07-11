using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests 
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void isPastryModelMade()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
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