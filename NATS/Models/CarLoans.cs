using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class CarLoans
    {
        public int LoanId { get; set; }
        public int CarSoldId { get; set; }
        public int FinanceCompanyId { get; set; }
        public DateTime? RepaymentStDate { get; set; }
        public DateTime? RepaymentEndDate { get; set; }
        public bool? MonthlyRepayments { get; set; }

        public virtual CarsSold CarSold { get; set; }
        public virtual FinanceCompanies FinanceCompany { get; set; }
    }
}
