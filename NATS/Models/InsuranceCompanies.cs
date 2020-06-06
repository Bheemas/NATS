using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class InsuranceCompanies
    {
        public InsuranceCompanies()
        {
            InsurancePolicies = new HashSet<InsurancePolicies>();
        }

        public int InsuranceCompanyId { get; set; }
        public string InsuranceCompanyName { get; set; }

        public virtual ICollection<InsurancePolicies> InsurancePolicies { get; set; }
    }
}
