using LoginApp.Models;
using System.Collections.Generic;

namespace LoginApp.DataAccess.Interfaces
{
    public interface ILoginAccess
    {
        bool Login(LoginInfo loginInfo);

        IEnumerable<LoginTimeInfo> GetLogins(string userId);
    }
}
