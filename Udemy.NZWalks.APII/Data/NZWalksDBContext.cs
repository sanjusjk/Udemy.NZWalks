using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Udemy.NZWalks.API.Models.Domain;

namespace Udemy.NZWalks.API.Data
{
    public class NZWalksDBContext :DbContext
    {
        public NZWalksDBContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Difficulty> Difficulties{ get; set; }
        public DbSet<Region> Regions{ get; set; }
        public DbSet<Walk> Walks{ get; set; }

    }
}
