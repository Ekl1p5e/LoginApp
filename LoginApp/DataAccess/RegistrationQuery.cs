using LoginApp.DataAccess.Interfaces;
using LoginApp.Models.Entities;
using System;
using System.Linq;

namespace LoginApp.DataAccess
{
    public class RegistrationQuery : IRegistrationQuery
    {
        private readonly IRegistrationAccess _registrationAccess;

        public RegistrationQuery(IRegistrationAccess registrationAccess)
        {
            _registrationAccess = registrationAccess ?? throw new ArgumentNullException(nameof(registrationAccess));
        }

        public Registration RegisteredUser(string userName, string password)
        {
            return _registrationAccess.RegisteredUsers(userName, password)
                .FirstOrDefault();
        }
    }
}
