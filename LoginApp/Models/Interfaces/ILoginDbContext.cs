using LoginApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoginApp.Models.Interfaces
{
    public interface ILoginDbContext
    {
        DbSet<Registration> Registrations { get; }

        DbSet<LoginTime> LoginTimes { get; }

        void Add<T>(T entity);

        void SaveChanges();
    }
}
