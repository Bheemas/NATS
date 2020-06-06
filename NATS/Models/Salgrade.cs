using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class Salgrade
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public decimal? Losal { get; set; }
        public decimal? Hisal { get; set; }
    }
}
