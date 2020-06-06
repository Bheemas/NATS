using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class VehicleCategories
    {
        public VehicleCategories()
        {
            CarsForSale = new HashSet<CarsForSale>();
        }

        public int VehicleCategoryCode { get; set; }
        public string VehicleCategoryDesc { get; set; }

        public virtual ICollection<CarsForSale> CarsForSale { get; set; }
    }
}
