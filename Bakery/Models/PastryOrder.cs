namespace Bakery.Models
{
  public class PastryOrder
  {
    public int OrderedPastries { get; set; }
    public int BasePrice { get; set; }
    public int PastriesPrice { get; set; }
  
    public PastryOrder(int orderedPastries)
    {
      OrderedPastries = orderedPastries;
      PastriesPrice = 0;
    }

    public void SetPastriesPrice()
    {
      int[] emptyIntArray = new int[OrderedPastries];
      PastriesPrice += 2 * OrderedPastries;
      if (OrderedPastries > 2)
      {
        PastriesPrice -= emptyIntArray.Length / 3;
      }
    }
  }
}