using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class TimeSheetMaster
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int? ProjectId { get; set; }
        public byte Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDt { get; set; }

        public virtual Employees Emp { get; set; }
    }
}
