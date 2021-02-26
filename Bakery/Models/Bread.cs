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
      BreadPrice = OrderedBread * 5;
    }
  }
}