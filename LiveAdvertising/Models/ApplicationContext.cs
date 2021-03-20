using LiveAdvertising.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveAdvertising.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }

        public DbSet<Stream> Streams { get; set; }

        public DbSet<Message> Messages { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}
