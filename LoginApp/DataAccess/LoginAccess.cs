using LoginApp.DataAccess.Interfaces;
using LoginApp.Models;

namespace LoginApp.DataAccess
{
    public class LoginAccess : ILoginAccess
    {
        public bool Login(LoginInfo loginInfo)
        {
            return true;
        }
    }
}
