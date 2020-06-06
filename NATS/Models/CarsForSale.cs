using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class CarsForSale
    {
        public CarsForSale()
        {
            CarsSold = new HashSet<CarsSold>();
        }

        public int CarForSaleId { get; set; }
        public int ManufacturerId { get; set; }
        public int ModelCode { get; set; }
        public int VehicleCategoryCode { get; set; }
        public decimal AskingPrice { get; set; }
        public string CurrentMileage { get; set; }
        public DateTime DateAcquired { get; set; }
        public string RegistrationYear { get; set; }

        public virtual VehicleCategories VehicleCategoryCodeNavigation { get; set; }
        public virtual ICollection<CarsSold> CarsSold { get; set; }
    }
}
