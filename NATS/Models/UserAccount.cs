using System;
using System.Collections.Generic;

namespace NATS.Models
{
    public partial class UserAccount
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string ActivationKey { get; set; }
        public string Notes { get; set; }
        public string SecurityQuestion { get; set; }
        public DateTime? DateCreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public byte? IsActive { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
}
