using Microsoft.EntityFrameworkCore;

namespace Don.SportsStoreCore.EntityFrameworkCore
{
    public static class SportsStoreCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SportsStoreCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}