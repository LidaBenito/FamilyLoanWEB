using FamilyLoan.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyLoan.Infra.Data.Sql.Configurations
{
    internal class ProfitConfig : IEntityTypeConfiguration<Profit>
    {
        public void Configure(EntityTypeBuilder<Profit> builder)
        {
            builder.Property(c => c.Description).HasMaxLength(500);

        }
    }
}
