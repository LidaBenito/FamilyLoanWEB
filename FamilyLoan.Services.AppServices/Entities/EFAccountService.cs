using FamilyLoan.Domain.Contacts.IServices;
using FamilyLoan.Domain.Core.DTO;
using FamilyLoan.Domain.Core.Entities;
using System;
using System.Collections.Generic;

namespace FamilyLoan.Services.AppServices.Entities
{
    public class EFAccountService : AccountService
    {
        public List<Account> GetPayments(PaymentSearchDTO paymentSearch)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetPayments(DateTime date)
        {
            throw new NotImplementedException();
        }

        public double GetSumAccountAmount(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
