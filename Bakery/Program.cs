using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("----------Pierre's----------");
      Console.WriteLine("Welcome to Pierre's Bakery, we've the finest selection of bread and pastries. What kind? What do you mean what kind. Bread and pastries, those kinds!");
      Console.WriteLine("----------------------------");
      Console.WriteLine("How many loaves of bread would you like?");
      int orderedBread = int.Parse(Console.ReadLine());
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      Console.WriteLine("How many pastries would you like?");
      int orderedPastries = int.Parse(Console.ReadLine());
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      newBreadOrder.SetBreadPrice();
      newPastryOrder.SetPastriesPrice();
      int total = newBreadOrder.BreadPrice + newPastryOrder.PastriesPrice;
      Console.WriteLine($"Your total is ${total}");
      Console.WriteLine("Thank you for shopping with us!");
    }
  }
}