using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class Bonus
    {
        public int Id { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public decimal? Sal { get; set; }
        public decimal? Comm { get; set; }
    }
}
