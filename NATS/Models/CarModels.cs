using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class CarModels
    {
        public int CarModelId { get; set; }
        public int ManufacturerCode { get; set; }
        public string ModelName { get; set; }

        public virtual CarManufacturers CarModel { get; set; }
    }
}
