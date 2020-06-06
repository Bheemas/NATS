using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class EmpDetails
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public string EmpType { get; set; }
        public string EmpFunction { get; set; }
        public string EmpDepartment { get; set; }
        public string EmpAccountName { get; set; }
        public string EmpEmployeeId { get; set; }
        public string EmpEmail { get; set; }
    }
}
