using FamilyLoan.Domain.Core.Common;
using System.Linq;

namespace FamilyLoan.Domain.Contacts.Repository
{
    public interface BaseRepository<TEntity> where TEntity:BaseEntity
    {
        TEntity Add(TEntity entity);
        IQueryable<TEntity> GetAll();
        TEntity Get(int id);
        void DeleteByID(int id);
        void SaveChange();
       
      
    }
}
