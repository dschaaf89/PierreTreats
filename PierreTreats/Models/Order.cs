namespace PierreTreats.Models
{
    public class Order
    {
           
        public int OrderId  { get; set; }
        public int StockId  { get; set; }
       public virtual ApplicationUser User { get; set; }
       public Stock Stock { get; set; }
    }
}