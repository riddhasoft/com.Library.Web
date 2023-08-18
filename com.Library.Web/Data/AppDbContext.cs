using com.Library.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace com.Library.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {

        }

        public DbSet<BookModel> Book { get; set; }
        public DbSet<BookIdentificationModel> BookIdentification { get; set; }
        public DbSet<StudentModel> Student { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<BookInOutHistoryModel> BookInOutHistory { get; set; }

    }
}
