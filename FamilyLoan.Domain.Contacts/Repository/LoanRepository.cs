using FamilyLoan.Domain.Core.Entities;

namespace FamilyLoan.Domain.Contacts.Repository
{
    public interface LoanRepository:BaseRepository<Loan>
    {
        Loan Update(Loan entity);

    }
}
