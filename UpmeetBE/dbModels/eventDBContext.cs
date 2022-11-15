using System;
using Microsoft.EntityFrameworkCore;

namespace UpmeetBE.dbModels
{
    public class eventDBContext : DbContext
    {
        public eventDBContext(DbContextOptions<DbContext> options) : base(options) { }

        public DbSet<garret> Orders { get; set; }
    }
}