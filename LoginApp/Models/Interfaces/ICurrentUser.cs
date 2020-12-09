namespace LoginApp.Models.Interfaces
{
    public interface ICurrentUser
    {
        void Update(string userName);

        public string UserId { get; }
    }
}
