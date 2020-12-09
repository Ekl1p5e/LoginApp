using LoginApp.Models.Entities;
using System.Collections.Generic;

namespace LoginApp.DataAccess.Interfaces
{
    public interface IRegistrationAccess
    {
        void Register(Registration registration);

        IEnumerable<Registration> RegisteredUsers(string userName, string password);
    }
}
