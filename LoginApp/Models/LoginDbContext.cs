using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LoginApp.Models
{
    public partial class LoginDbContext : DbContext
    {
        public LoginDbContext()
        {
        }

        public LoginDbContext(DbContextOptions<LoginDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LoginTime> LoginTimes { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LoginDb;Integrated Security=True;Pooling=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LoginTime>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PK__LoginTim__4DDA281889591557");

                entity.ToTable("LoginTime");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.LoginTimes)
                    .HasForeignKey(d => d.RegistrationId)
                    .HasConstraintName("FK__LoginTime__Regis__34C8D9D1");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("Registration");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
