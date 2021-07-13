using FamilyLoan.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FamilyLoan.Infra.Data.Sql.Configurations
{
    internal class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
          
            builder.Property(c => c.Family).HasMaxLength(50).IsRequired(true);
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(c => c.Mobile).HasMaxLength(150);
            builder.Property(c => c.ProfileImage).IsUnicode(false);
            builder.Property(c => c.FullName).HasField("_fullName");

        }
    }
}
