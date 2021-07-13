using FamilyLoan.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyLoan.Infra.Data.Sql.Configurations
{
    internal class LoanItemConfig : IEntityTypeConfiguration<LoanItem>
    {
        public void Configure(EntityTypeBuilder<LoanItem> builder)
        {
            builder.Property(c => c.LoanID).IsUnicode(true);
        }
    }
}
