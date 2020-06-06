using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class CarFeatures
    {
        public CarFeatures()
        {
            CustomerPreferences = new HashSet<CustomerPreferences>();
            FeaturesOnCarsForSale = new HashSet<FeaturesOnCarsForSale>();
        }

        public int CarFeatureId { get; set; }
        public bool AirConditioning { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public bool? Sedan { get; set; }

        public virtual ICollection<CustomerPreferences> CustomerPreferences { get; set; }
        public virtual ICollection<FeaturesOnCarsForSale> FeaturesOnCarsForSale { get; set; }
    }
}
