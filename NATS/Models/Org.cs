using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class Org
    {
        public int OrgId { get; set; }
        public string Organization { get; set; }
        public string Parent { get; set; }
        public int Id { get; set; }
    }
}
