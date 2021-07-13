using FamilyLoan.Domain.Core.Entities;

namespace FamilyLoan.Domain.Contacts.Repository
{
    public interface LoanItemRepository:BaseRepository<LoanItem>
    {
        LoanItem Update(LoanItem entity);

        void InsertRange(Loan loanObject);
    }
}
