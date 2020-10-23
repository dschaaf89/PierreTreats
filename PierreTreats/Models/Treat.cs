using System;
using System.Collections.Generic;

namespace PierreTreats.Models
{
    public class Treat
    {
        public Treat(){
            this.TreatFlavor = new HashSet<TreatFlavor>();
        }
        public string Name { get; set; }
        public string TreatId { get; set; }
         public virtual ICollection<TreatFlavor> TreatFlavor {get;set;}
    }
}