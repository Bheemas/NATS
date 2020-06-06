using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class CustomerPayments
    {
        public int CustomerPaymentId { get; set; }
        public int CarSoldId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentStatusCode { get; set; }
        public DateTime? CustomerPaymentDueDate { get; set; }
        public DateTime? CustomerPaymentDateMade { get; set; }

        public virtual CarsSold CarSold { get; set; }
    }
}
