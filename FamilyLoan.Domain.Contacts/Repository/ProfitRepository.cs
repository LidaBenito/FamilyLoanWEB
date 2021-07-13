using FamilyLoan.Domain.Core.Entities;

namespace FamilyLoan.Domain.Contacts.Repository
{
    public interface ProfitRepository:BaseRepository<Profit>
    {
        Profit Update(Profit entity);

    }
}
