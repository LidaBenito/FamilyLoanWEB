using FamilyLoan.Domain.Core.Entities;
using System.Collections.Generic;

namespace FamilyLoan.Domain.Contacts.Services

{
    public interface LoanItemService
    {
        List<LoanItem> GetUnpaidList(int PersonID,int LoanID);
        float GetAmount(int loanItemID);

    }
}
