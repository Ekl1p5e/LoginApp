using LoginApp.Models;

namespace LoginApp.DataAccess.Interfaces
{
    public interface ILoginAccess
    {
        bool Login(LoginInfo loginInfo);
    }
}
