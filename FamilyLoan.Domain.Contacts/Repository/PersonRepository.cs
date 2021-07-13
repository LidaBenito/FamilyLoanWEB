using FamilyLoan.Domain.Core.Entities;
using System.Collections.Generic;

namespace FamilyLoan.Domain.Contacts.Repository
{
    public interface PersonRepository:BaseRepository<Person>
    {
        IEnumerable<Person> Get(string query, params object[] parameters);
        Person Update(Person entity);

        List<Person> GetPeopleWithUserInfo();
        Loan HasUnfinishedLoan(int personID);
    }
}
