using FamilyLoan.Domain.Contacts.Services;
using FamilyLoan.Domain.Core.DTO;
using FamilyLoan.Domain.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace FamilyLoan.Services.AppServices.Entities
{
    public class EFLoanService : LoanService
    {
        public double GetLoansAmount(double loanAmount)
        {
            throw new NotImplementedException();
        }

        public byte GetPersonLoanNo(int personID)
        {
            throw new NotImplementedException();
        }

        public IList GetPersonWithAggregateLoanInformation()
        {
            throw new NotImplementedException();
        }

        public List<PersonLoanDTO> GetPersonWithLoanInformation()
        {
            throw new NotImplementedException();
        }

        public void InsertByLoan(Loan obj)
        {
            throw new NotImplementedException();
        }
    }
}
