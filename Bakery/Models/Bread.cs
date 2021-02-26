namespace Bakery.Models
{
  public class BreadOrder
  {
    public int OrderedBread { get; set; }
    public int BreadPrice { get; set; }
    public BreadOrder(int breadOrder, int breadPrice)
    {
      OrderedBread = breadOrder;
      BreadPrice = breadPrice;
    }
  }
}