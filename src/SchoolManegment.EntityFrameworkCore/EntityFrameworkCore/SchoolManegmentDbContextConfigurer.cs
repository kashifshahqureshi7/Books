using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SchoolManegment.EntityFrameworkCore
{
    public static class SchoolManegmentDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SchoolManegmentDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SchoolManegmentDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
