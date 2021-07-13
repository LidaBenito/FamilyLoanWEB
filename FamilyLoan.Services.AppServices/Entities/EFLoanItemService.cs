using FamilyLoan.Domain.Contacts.Services;
using FamilyLoan.Domain.Core.Entities;
using System.Collections.Generic;

namespace FamilyLoan.Services.AppServices.Entities
{
    public class EFLoanItemService : LoanItemService
    {
        public float GetAmount(int loanItemID)
        {
            throw new System.NotImplementedException();
        }

        public List<LoanItem> GetUnpaidList(int PersonID, int LoanID)
        {
            throw new System.NotImplementedException();
        }
    }
}
