using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class PaymentStatus
    {
        public int PaymentStatusCode { get; set; }
        public string PaymentStatusDesc { get; set; }
    }
}
