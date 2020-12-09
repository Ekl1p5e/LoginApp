using System.Collections.Generic;

#nullable disable

namespace LoginApp.Models.Entities
{
    public partial class Registration
    {
        public Registration()
        {
            LoginTimes = new HashSet<LoginTime>();
        }

        public int RegistrationId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public virtual ICollection<LoginTime> LoginTimes { get; set; }
    }
}
