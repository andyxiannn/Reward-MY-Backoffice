using Microsoft.EntityFrameworkCore;
using Reward_Backoffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reward_Backoffice.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public static IQueryable<Client> Client { get; internal set; }  
        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }
        public DbSet<Dealer> z3s1o_dealers { get; set; }
        public DbSet<Client> z3s1o_client { get; set; }
        public DbSet<Branch> z3s1o_branch { get; set; }


        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Dealer>().ToTable("z3s1o_dealers");
        //}
    }
}
