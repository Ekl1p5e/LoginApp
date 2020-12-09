using LoginApp.DataAccess.Interfaces;
using LoginApp.Models;
using LoginApp.Models.Entities;
using LoginApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoginApp.DataAccess
{
    public class LoginAccess : ILoginAccess
    {
        private readonly ILoginDbContext _loginDbContext;
        private readonly IRegistrationQuery _registrationQuery;

        public LoginAccess(
            ILoginDbContext loginDbContext,
            IRegistrationQuery registrationQuery)
        {
            _loginDbContext = loginDbContext ?? throw new ArgumentNullException(nameof(loginDbContext));
            _registrationQuery = registrationQuery ?? throw new ArgumentNullException(nameof(registrationQuery));
        }

        public IEnumerable<LoginTimeInfo> GetLogins(string userId)
        {
            try
            {
                var logins =_loginDbContext.LoginTimes
                    .Where(r => r.Registration.EmailAddress == userId)
                    .Select(r => new LoginTimeInfo { Name = r.Registration.FirstName, Time = r.Timestamp });

                return logins;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public bool Login(LoginInfo loginInfo)
        {
            try
            {
                var registeredUser = _registrationQuery.RegisteredUser(loginInfo.UserName, loginInfo.Password);
                if (registeredUser != null)
                {
                    _loginDbContext.Add(new LoginTime
                    {
                         RegistrationId = registeredUser.RegistrationId,
                    });
                    _loginDbContext.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {

            }

            return false;
        }
    }
}
