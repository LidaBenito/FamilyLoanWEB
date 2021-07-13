using FamilyLoan.Domain.Contacts.Repository;
using FamilyLoan.Domain.Core.Entities;
using FamilyLoan.Infra.Data.Sql.Context;
using System;

namespace FamilyLoan.Infra.Data.Sql.Repository
{
    public class EFAccountRepository : EFBaseRepository<Account>, AccountRepository
    {
        public EFAccountRepository(FamilyLoanDbContext dbContext) : base(dbContext)
        {
        }

        public Account Update(Account entity)
        {
            var result = _dbContext.Accounts.Find(entity.ID);
            result.ModifiedDateTime = DateTime.Now;
            result.PaymentType = entity.PaymentType;
            result.person = entity.person;
            _dbContext.SaveChanges();
            return (result);

        }
    }
}
