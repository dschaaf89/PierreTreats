using System;
using System.Collections.Generic;
namespace PierreTreats.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.TreatFlavor = new HashSet<TreatFlavor>();
        }
        public string FlavorType { get; set; }
        public int FlavorId { get; set; }
        public virtual ICollection<TreatFlavor> TreatFlavor {get;set;}
        public virtual ApplicationUser User { get; set; }
    }
}