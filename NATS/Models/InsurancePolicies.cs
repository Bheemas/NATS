using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class InsurancePolicies
    {
        public int PolicyId { get; set; }
        public int InsuranceCompanyId { get; set; }
        public int? CarSoldId { get; set; }

        public virtual CarsSold CarSold { get; set; }
        public virtual InsuranceCompanies InsuranceCompany { get; set; }
    }
}
