using Entities.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Hmo:DbContext
    {
      public Hmo() { }
        //----------------------------------------------------------------------------------
        public Hmo(DbContextOptions<Hmo> options)
            : base(options)
        {
          
        }
        //----------------------------------------------------------------------------------

        public virtual DbSet<Member> members { get; set; }
        //----------------------------------------------------------------------------------

        public virtual DbSet<Covid> covids { get; set; }
        //----------------------------------------------------------------------------------


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ESTER\\SQLEXPRESS;database=HmoDb;trusted_connection=true;TrustServerCertificate=True");

        }
        //----------------------------------------------------------------------------------

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasMany(e => e.covidDates)
                .WithOne(e => e.member)
                .HasForeignKey(e => e.memberId)
                .HasPrincipalKey(e => e.id);
        }
        //----------------------------------------------------------------------------------



    }

}

