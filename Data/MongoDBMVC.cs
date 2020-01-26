using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models
{
    public class MongoDBMVC : DbContext
    {
        public MongoDBMVC (DbContextOptions<MongoDBMVC> options)
            : base(options)
        {
        }

        public DbSet<webapi.Models.Users> Users { get; set; }
    }
}
