using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Mesenger.Models
{
    public class UsersContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public UsersContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
