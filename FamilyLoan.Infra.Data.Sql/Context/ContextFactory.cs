using Microsoft.EntityFrameworkCore;

namespace FamilyLoan.Infra.Data.Sql.Context
{
    public static class ContextFactory
    {
        public static FamilyLoanDbContext GetSqlContext()
        {
            var builder = new DbContextOptionsBuilder<FamilyLoanDbContext>();
            builder.UseSqlServer("Server=.;Database=FamilyLoans;Integrated Security=True;MultipleActiveResultSets=true");
            return new FamilyLoanDbContext(builder.Options);
        }
    }
}
