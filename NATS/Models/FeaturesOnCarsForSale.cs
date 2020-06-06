using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class FeaturesOnCarsForSale
    {
        public int CarForSaleId { get; set; }
        public int CarFeatureId { get; set; }

        public virtual CarFeatures CarFeature { get; set; }
    }
}
