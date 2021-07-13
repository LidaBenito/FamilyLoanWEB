using FamilyLoan.Domain.Contacts.Repository;
using FamilyLoan.Domain.Core.Entities;
using FamilyLoan.Infra.Data.Sql.Context;
using System;
using System.Linq;

namespace FamilyLoan.Infra.Data.Sql.Repository
{
    public class EFLoanRepository : LoanRepository
    {
        private readonly FamilyLoanDbContext _dbContext;

        public EFLoanRepository(FamilyLoanDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Loan Add(Loan entity)
        {
            throw new NotImplementedException();
        }

        public void DeletebyEntity(Loan entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public Loan Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Loan> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public Loan Update(Loan entity)
        {
            throw new NotImplementedException();
        }
    }
}
