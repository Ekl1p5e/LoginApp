using LoginApp.Models.Interfaces;

namespace LoginApp.Models
{
    public class CurrentUser : ICurrentUser
    {
        public void Update(string userName)
        {
            UserId = userName;
        }

        public string UserId { get; private set; }
    }
}
