using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class TimesheetDetail
    {
        public int Id { get; set; }
        public int TimesheetId { get; set; }
        public int? ProjectId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? WorkDay { get; set; }
        public decimal? Hours { get; set; }
    }
}
