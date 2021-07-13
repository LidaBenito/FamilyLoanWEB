using FamilyLoan.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FamilyLoan.Infra.Data.Sql.Context
{

    public class FamilyLoanDbContext:DbContext
    {
     
        public DbSet<Account>  Accounts{ get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanItem> LoanItems { get; set; }
        public DbSet<Person>  People { get; set; }
        public DbSet<Profit>  Profits{ get; set; }
        public FamilyLoanDbContext(DbContextOptions<FamilyLoanDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.HasDefaultSchema("FamilyLoan");
            base.OnModelCreating(modelBuilder);
        }
    }
}
