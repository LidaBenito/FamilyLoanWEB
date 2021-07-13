using FamilyLoan.Domain.Contacts.Repository;
using FamilyLoan.Domain.Core.Entities;
using FamilyLoan.Infra.Data.Sql.Context;
using System;
using System.Linq;

namespace FamilyLoan.Infra.Data.Sql.Repository
{
    public class EFProfitRepository : ProfitRepository
    {
        private readonly FamilyLoanDbContext _dbContext;

        public EFProfitRepository(FamilyLoanDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Profit Add(Profit entity)
        {
            throw new NotImplementedException();
        }

        public void DeletebyEntity(Profit entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public Profit Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Profit> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public Profit Update(Profit entity)
        {
            throw new NotImplementedException();
        }
    }
}
