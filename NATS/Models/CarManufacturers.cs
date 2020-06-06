using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class CarManufacturers
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerFullName { get; set; }
        public string ManufacturerOtherDetail { get; set; }

        public virtual CarModels CarModels { get; set; }
    }
}
