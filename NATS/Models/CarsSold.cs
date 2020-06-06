using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class CarsSold
    {
        public CarsSold()
        {
            CarLoans = new HashSet<CarLoans>();
            CustomerPayments = new HashSet<CustomerPayments>();
            InsurancePolicies = new HashSet<InsurancePolicies>();
        }

        public int CarSoldId { get; set; }
        public int CarForSaleId { get; set; }
        public int CustomerId { get; set; }
        public decimal AgreedPrice { get; set; }
        public DateTime DateSold { get; set; }
        public decimal? MonthlyPaaymentAmt { get; set; }
        public DateTime MonthlyPaymentDate { get; set; }

        public virtual CarsForSale CarForSale { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual ICollection<CarLoans> CarLoans { get; set; }
        public virtual ICollection<CustomerPayments> CustomerPayments { get; set; }
        public virtual ICollection<InsurancePolicies> InsurancePolicies { get; set; }
    }
}
