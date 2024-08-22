using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SchoolManegment.Authorization.Roles;
using SchoolManegment.Authorization.Users;
using SchoolManegment.MultiTenancy;
using SchoolManegment.Entities;

namespace SchoolManegment.EntityFrameworkCore
{
    public class SchoolManegmentDbContext : AbpZeroDbContext<Tenant, Role, User, SchoolManegmentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SchoolManegmentDbContext(DbContextOptions<SchoolManegmentDbContext> options)
            : base(options)
        {
        }
        public DbSet<Author> Tbl_Author { get; set; }
        public DbSet<BookCover> Tbl_BookCover { get; set; }
        public DbSet<Book> Tbl_Book { get; set; }
    }
}
