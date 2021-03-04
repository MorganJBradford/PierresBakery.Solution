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
      string breadLoaves = Console.ReadLine();
      int orderedBread;
      bool isBreadWhole = int.TryParse(breadLoaves, out orderedBread);
      if (orderedBread == 0 || orderedBread < 0){
        Console.WriteLine("Please add only an intgers");
        Main();
      }
      Console.WriteLine("How many pastries would you like?");
      string pastryPieces = Console.ReadLine();
      int orderedPastries;
      bool arePastriesWhole = int.TryParse(pastryPieces, out orderedPastries);
      if (orderedPastries == 0 || orderedPastries < 0){
        Console.WriteLine("Please add only an intgers");
        Main();
      }
      BreadOrder newBreadOrder = new BreadOrder(orderedBread);
      PastryOrder newPastryOrder = new PastryOrder(orderedPastries);
      newBreadOrder.SetBreadPrice();
      newPastryOrder.SetPastriesPrice();
      int total = newBreadOrder.BreadPrice + newPastryOrder.PastriesPrice;
      Console.WriteLine($"Your total is ${total}");
      Console.WriteLine("Thank you for shopping with us!");
    }
  }
}