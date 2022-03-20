using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AcmeCorp.EntityFrameworkCore
{
    public static class AcmeCorpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AcmeCorpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AcmeCorpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
