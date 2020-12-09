using LoginApp.DataAccess.Interfaces;
using LoginApp.Models.Entities;
using LoginApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoginApp.DataAccess
{
    public class RegistrationAccess : IRegistrationAccess
    {
        private readonly ILoginDbContext _loginDbContext;

        public RegistrationAccess(ILoginDbContext loginDbContext)
        {
            _loginDbContext = loginDbContext ?? throw new ArgumentNullException(nameof(loginDbContext));
        }

        public void Register(Registration registration)
        {
            try
            {
                _loginDbContext.Add(registration);
                _loginDbContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public IEnumerable<Registration> RegisteredUsers(string userName, string password)
        {
            try
            {
                return _loginDbContext.Registrations
                    .Where(r => r.EmailAddress == userName)
                    .Where(r => r.Password == password);
            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}
