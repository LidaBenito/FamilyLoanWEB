using Microsoft.EntityFrameworkCore.Design;

namespace FamilyLoan.Infra.Data.Sql.Context
{
    public class FamilyLoanDbContextDesignTimeFactory : IDesignTimeDbContextFactory<FamilyLoanDbContext>
    {
        public FamilyLoanDbContext CreateDbContext(string[] args) => ContextFactory.GetSqlContext();
    }
}
