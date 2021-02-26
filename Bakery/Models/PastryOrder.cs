namespace Bakery.Models
{
  public class PastryOrder
  {
    public int OrderedPastries { get; set; }
    public int BasePrice { get; set; }
    public int SalePrice { get; set; }
    public int PastriesPrice { get; set; }
  

    public PastryOrder(int orderedPastries)
    {

    }
  }
}