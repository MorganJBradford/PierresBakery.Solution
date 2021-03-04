using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("----------Pierre's----------");
      Console.WriteLine("Welcome to Pierre's Bakery, we've the finest selection of bread and pastries.");
      Console.WriteLine("Bread: $5/each. We're also running a sale for buy 2 get 1 free!");
      Console.WriteLine("Pastries: $2/each, or 3 for $5");
      Console.WriteLine("----------------------------");
      Console.WriteLine("How many loaves of bread would you like?");
      int orderedBread = int.TryParse(Console.ReadLine());
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