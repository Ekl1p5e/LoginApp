using System;

#nullable disable

namespace LoginApp.Models.Entities
{
    public partial class LoginTime
    {
        public int LoginId { get; set; }

        public DateTime Timestamp { get; set; }

        public int? RegistrationId { get; set; }

        public virtual Registration Registration { get; set; }
    }
}
