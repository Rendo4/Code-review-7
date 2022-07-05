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
}