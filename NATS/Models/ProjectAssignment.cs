using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class ProjectAssignment
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
