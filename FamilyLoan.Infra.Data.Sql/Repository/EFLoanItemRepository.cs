using FamilyLoan.Domain.Contacts.Repository;
using FamilyLoan.Domain.Core.Entities;
using FamilyLoan.Infra.Data.Sql.Context;
using System;
using System.Linq;

namespace FamilyLoan.Infra.Data.Sql.Repository
{
    public class EFLoanItemRepository : LoanItemRepository
    {
        private readonly FamilyLoanDbContext _dbContext;

        public EFLoanItemRepository(FamilyLoanDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public LoanItem Add(LoanItem entity)
        {
            throw new NotImplementedException();
        }

        public void DeletebyEntity(LoanItem entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public LoanItem Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<LoanItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public void InsertRange(Loan loanObject)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public LoanItem Update(LoanItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
