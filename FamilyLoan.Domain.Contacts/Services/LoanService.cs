using FamilyLoan.Domain.Core.DTO;
using FamilyLoan.Domain.Core.Entities;
using System.Collections;
using System.Collections.Generic;

namespace FamilyLoan.Domain.Contacts.Services

{
    public  interface LoanService
    {
        
        byte GetPersonLoanNo(int personID);
        double GetLoansAmount(double loanAmount);
        List<PersonLoanDTO> GetPersonWithLoanInformation();
        IList GetPersonWithAggregateLoanInformation();
        void InsertByLoan(Loan obj);
    }
}
