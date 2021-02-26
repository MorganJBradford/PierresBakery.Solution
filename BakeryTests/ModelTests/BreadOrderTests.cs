using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void  BreadOrderConstructor_CreatesInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder(2, 5);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrdered_Int()
    {
      int orderedBread = 2;
      int breadPrice = 5;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread, breadPrice);
      int result = newBreadOrder.OrderedBread;
      Assert.AreEqual(orderedBread, result);
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsOrderPrice_Int()
    {
      int orderedBread = 2;
      int breadPrice = 10;
      BreadOrder newBreadOrder = new BreadOrder(orderedBread, breadPrice);
      int result = newBreadOrder.BreadPrice;
      Assert.AreEqual(breadPrice, result);
    }
  }
}