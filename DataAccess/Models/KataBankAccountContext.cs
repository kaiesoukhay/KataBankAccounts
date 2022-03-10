using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models
{
    public partial  class KataBankAccountContext : DbContext
    {
        public KataBankAccountContext()
        {
        }
        public KataBankAccountContext(DbContextOptions<KataBankAccountContext> options)
         : base(options)
        {
        }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name = ConnectionStrings:DefaultConnection");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
