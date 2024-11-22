using GSNet24.Model;
using Microsoft.EntityFrameworkCore;

namespace GSNet24.Context
{
    public class AppContextDb : DbContext
    {
        public AppContextDb(DbContextOptions<AppContextDb> options) : base(options) { }

        public DbSet<AparelhoModel> Aparelho { get; set; }
    }
}
