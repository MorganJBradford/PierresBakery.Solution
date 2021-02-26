using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreatesInstanceOfPastryOrder_PastryOrder()
    {
      PastryOrder newPastryOrder = new PastryOrder(2);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void GetOrderedPastries_ReturnsPastriesOrdered_Int()
    {
      int orderedPastries = 2;
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      int result = newPastryOrder.OrderedPastries;
      Assert.AreEqual(orderedPastries, result);
    }

    [TestMethod]
    public void SetPastriesPrice_ReturnsPriceForTwoPastries_Int()
    {
      int orderedPastries = 2;
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      newPastryOrder.SetPastriesPrice();
      int result = newPastryOrder.PastriesPrice;
      Assert.AreEqual(orderedPastries, result);
    }
  }
}