using System.Collections.Generic;
namespace Bakery.Models
{
  public class BreadOrder
  {
    public int OrderedBread { get; set; }
    public int BreadPrice { get; set; }
    public BreadOrder(int breadOrder)
    {
      OrderedBread = breadOrder;
      BreadPrice = 0;
    }

    public void SetBreadPrice()
    {
      int[] emptyIntArray = new int[OrderedBread];
      BreadPrice = OrderedBread * 5;
      if (OrderedBread > 2)
      {
        BreadPrice -= (emptyIntArray.Length / 3) * 5;
      }
    }
  }
}