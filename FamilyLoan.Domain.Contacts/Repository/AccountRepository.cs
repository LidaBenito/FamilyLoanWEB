using FamilyLoan.Domain.Core.Entities;

namespace FamilyLoan.Domain.Contacts.Repository
{
    public  interface AccountRepository:BaseRepository<Account>
    {
        Account Update(Account entity);

    }
}
