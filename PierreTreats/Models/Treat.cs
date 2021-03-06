using System;
using System.Collections.Generic;

namespace PierreTreats.Models
{
    public class Treat
    {
        public Treat(){
            this.TreatFlavor = new HashSet<TreatFlavor>();
            this.Stock = new HashSet<Stock>();
        }
        public string Name { get; set; }
        public int TreatId { get; set; }
         public virtual ICollection<TreatFlavor> TreatFlavor {get;set;}
          public virtual ICollection<Stock> Stock {get;set;}
         public virtual ApplicationUser User { get; set; }
    }
}