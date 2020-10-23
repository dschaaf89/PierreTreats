using System.Collections.Generic;

namespace PierreTreats.Models
{
  public class Stock
  {
    public Stock()
    {
      this.Order = new HashSet<Order>();
    }
    public int StockId { get; set; }
    public bool InStock { get; set; }
    public int TreatId { get; set; }
    public virtual Treat Treat { get; set; }
    public virtual ICollection<Order> Order { get; set; }
  }
}