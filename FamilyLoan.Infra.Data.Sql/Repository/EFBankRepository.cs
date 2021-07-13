using FamilyLoan.Domain.Contacts.Repository;
using FamilyLoan.Domain.Core.Entities;
using FamilyLoan.Infra.Data.Sql.Context;
using System;
using System.Linq;

namespace FamilyLoan.Infra.Data.Sql.Repository
{
    public class EFBankRepository : BankRepository
    {
        private readonly FamilyLoanDbContext _dbContext;

        public EFBankRepository(FamilyLoanDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Bank Add(Bank entity)
        {
            _dbContext.Set<Bank>().Add(entity);
            entity.ModifiedDateTime = DateTime.Now;
            _dbContext.SaveChanges();
            return entity;
        }

   

        public void DeleteByID(int id)
        {
            var entity = Get(id);
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public Bank Get(int id)
        {
            Bank bank = _dbContext.Set<Bank>().Find(id);
            return (bank);
        }

        public IQueryable<Bank> GetAll()
        {
            return _dbContext.Set<Bank>().AsQueryable();
        }

        public void SaveChange()
        {
            _dbContext.SaveChanges();
        }

        public Bank Update(Bank entity)
        {
            var result = _dbContext.Banks.Find(entity.ID);
            result.Description = entity.Description;
            result.AmountDate = entity.AmountDate;
            result.CreatededDateTime = entity.CreatededDateTime;
            result.ModifiedDateTime = DateTime.Now;
            _dbContext.SaveChanges();
            return (result);
        }
    }
}
