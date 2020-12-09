using System;

#nullable disable

namespace LoginApp.Models
{
    public partial class LoginTime
    {
        public int LoginId { get; set; }

        public int? RegistrationId { get; set; }

        public DateTime Timestamp { get; set; }

        public virtual Registration Registration { get; set; }
    }
}
