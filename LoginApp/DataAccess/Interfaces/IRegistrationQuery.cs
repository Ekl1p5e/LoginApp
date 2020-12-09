using LoginApp.Models.Entities;

namespace LoginApp.DataAccess.Interfaces
{
    public interface IRegistrationQuery
    {
        Registration RegisteredUser(string userName, string password);
    }
}
