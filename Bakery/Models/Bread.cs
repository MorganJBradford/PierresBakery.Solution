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
  }
}