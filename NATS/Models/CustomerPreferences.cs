using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class CustomerPreferences
    {
        public int CustomerPreferenceId { get; set; }
        public int CustomerId { get; set; }
        public int CarFeatureId { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }

        public virtual CarFeatures CarFeature { get; set; }
        public virtual Customers Customer { get; set; }
    }
}
