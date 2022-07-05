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
      Assert.AreEqual(3, newBread.getLoaves());
      newBread.SetPrice();
      Assert.AreEqual(10, newBread.getPrice());
    }
  }
  [TestClass]
  public class PastryTests
  {
  [TestMethod]
  public void isPastryPriceRead()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(6, newPastry.getPastries());
      newPastry.SetPrice();
      Assert.AreEqual(10, newPastry.getPrice());
    }
  }
}