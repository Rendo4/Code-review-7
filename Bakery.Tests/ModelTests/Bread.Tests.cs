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
      Assert.AreEqual(typeof(Bread), newBread.GetType());
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
}