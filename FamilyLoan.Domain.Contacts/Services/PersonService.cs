using FamilyLoan.Domain.Core.Entities;
using System.Collections.Generic;

namespace FamilyLoan.Domain.Contacts.Services

{
    public interface PersonService
    {
        void LoanForPerson(int personId, Loan loan);
        List<Person> GetAllPerson();
        Person GetPerson(int personId);
        void AddPerson(Person person);
        void UpdatePerson(int personId);
        void DeletePerson(int personId);
        List<Loan> GetlAllLoans(int personId);
        void DeleteLoan(int loanId);


    }
}
