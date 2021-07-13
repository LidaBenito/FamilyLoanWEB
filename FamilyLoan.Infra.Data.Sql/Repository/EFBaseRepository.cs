using FamilyLoan.Domain.Contacts.Repository;
using FamilyLoan.Domain.Core.Common;
using FamilyLoan.Infra.Data.Sql.Context;
using System;
using System.Linq;

namespace FamilyLoan.Infra.Data.Sql.Repository
{
    public abstract class EFBaseRepository<TEntity> : BaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly FamilyLoanDbContext _dbContext;

        public EFBaseRepository(FamilyLoanDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public TEntity Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
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

        public TEntity Get(int id)
        {
            TEntity entity = _dbContext.Set<TEntity>().Find(id);
            return (entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }

        public void SaveChange()
        {
            _dbContext.SaveChanges();

        }
    }
}
