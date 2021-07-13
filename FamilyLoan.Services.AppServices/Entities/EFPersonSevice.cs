using FamilyLoan.Domain.Contacts.Services;
using FamilyLoan.Domain.Core.Entities;
using System.Collections.Generic;

namespace FamilyLoan.Services.AppServices.Entities
{
    public class EFPersonSevice : PersonService
    {
        public void AddPerson(Person person)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLoan(int loanId)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePerson(int personId)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> GetAllPerson()
        {
            throw new System.NotImplementedException();
        }

        public List<Loan> GetlAllLoans(int personId)
        {
            throw new System.NotImplementedException();
        }

        public Person GetPerson(int personId)
        {
            throw new System.NotImplementedException();
        }

        public void LoanForPerson(int personId, Loan loan)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePerson(int personId)
        {
            throw new System.NotImplementedException();
        }
    }
}
