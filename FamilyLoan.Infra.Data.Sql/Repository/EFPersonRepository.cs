using FamilyLoan.Domain.Contacts.Repository;
using FamilyLoan.Domain.Core.Entities;
using FamilyLoan.Infra.Data.Sql.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyLoan.Infra.Data.Sql.Repository
{
    public class EFPersonRepository : PersonRepository
    {
        private readonly FamilyLoanDbContext _dbContext;

        public EFPersonRepository(FamilyLoanDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Person Add(Person entity)
        {
            throw new NotImplementedException();
        }

        public void DeletebyEntity(Person entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> Get(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPeopleWithUserInfo()
        {
            throw new NotImplementedException();
        }

        public Loan HasUnfinishedLoan(int personID)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public Person Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
