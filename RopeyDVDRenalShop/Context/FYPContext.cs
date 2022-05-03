using Microsoft.EntityFrameworkCore;
using RopeyDVDRenalShop.Models;

namespace RopeyDVDRenalShop.Context
{
    public class FYPContext: DbContext
    {
        public FYPContext(DbContextOptions<FYPContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<CastMember>()
            // .HasKey(c => new { c.Actor, c.DvdTittle });
            // modelBuilder.Entity<CastMember>()
            //.HasOne(c => c.Actor)
            //.WithMany(c => c.castMember)
            //.HasForeignKey(c => c.ActorNumber);

            //modelBuilder.Entity<CastMember>()
            //.HasOne(c => c.DvdTittle)
            //.WithMany(c => c.castMember)
            //.HasForeignKey(c => c.DvdNumber);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<CastMember> castmembers { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<DvdCategory> dvdCategories { get; set; }
        public DbSet<DvdTitle> dvdTittles { get; set; }
        public DbSet<Loan> loans { get; set; }
        public DbSet<LoanType> LoanTypes { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<MembershipCategory> membershipCategories { get; set; }
        public DbSet<DvdCopy> DvdCopy { get; set; }

    }
}
