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
    Dictionary<int, int> myDictionary = new Dictionary<int, int>() { {5, 5}, {7, 10} };

    public void SetBreadPrice()
    {
      BreadPrice = OrderedBread * 5;
      foreach(KeyValuePair<int, int> entry in myDictionary)
      {
        if (OrderedBread == entry.Key)
        {
          BreadPrice -= entry.Value;
        }
      }
      if (OrderedBread % 3 == 0)
      {
        BreadPrice -= BreadPrice / 3;
      }
      else if (OrderedBread % 2 == 0 && OrderedBread != 2)
      {
        BreadPrice -= BreadPrice / 4;
      }
    }
  }
}