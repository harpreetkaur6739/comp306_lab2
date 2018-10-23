using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _300910377_KAUR__300916412_YANG__Lab2.Models;

namespace _300910377_KAUR__300916412_YANG__Lab2.Models
{
    public class _300910377_KAUR__300916412_YANG__Lab2Context : DbContext
    {
        public _300910377_KAUR__300916412_YANG__Lab2Context (DbContextOptions<_300910377_KAUR__300916412_YANG__Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<_300910377_KAUR__300916412_YANG__Lab2.Models.Users> Users { get; set; }

        public DbSet<_300910377_KAUR__300916412_YANG__Lab2.Models.UserInfo> UserInfo { get; set; }

        public DbSet<_300910377_KAUR__300916412_YANG__Lab2.Models.Movie> Movie { get; set; }

        public DbSet<_300910377_KAUR__300916412_YANG__Lab2.Models.Comment> Comment { get; set; }

        public DbSet<_300910377_KAUR__300916412_YANG__Lab2.Models.Association> Association { get; set; }

        internal void Find(Users user)
        {
            throw new NotImplementedException();
        }

        internal void Find(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
