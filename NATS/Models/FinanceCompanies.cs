using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class FinanceCompanies
    {
        public FinanceCompanies()
        {
            CarLoans = new HashSet<CarLoans>();
        }

        public int FinanceCompanyId { get; set; }
        public string FinanceCompanyName { get; set; }

        public virtual ICollection<CarLoans> CarLoans { get; set; }
    }
}
