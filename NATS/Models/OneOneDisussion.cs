using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class OneOneDisussion
    {
        public int Id { get; set; }
        public int SupervisorId { get; set; }
        public int TeamMemberId { get; set; }
        public string DiscussionNotes1 { get; set; }
        public string DiscussionNotes2 { get; set; }
        public string DiscussionNotes3 { get; set; }
        public DateTime? DiscussionDate { get; set; }
        public DateTime? DisucssionUpdatedBy { get; set; }
    }
}
