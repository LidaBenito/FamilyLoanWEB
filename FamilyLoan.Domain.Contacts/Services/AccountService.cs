using FamilyLoan.Domain.Core.DTO;
using FamilyLoan.Domain.Core.Entities;
using System;
using System.Collections.Generic;

namespace FamilyLoan.Domain.Contacts.IServices
{
    public  interface AccountService
    {
        double GetSumAccountAmount(double amount);
        List<Account> GetPayments(PaymentSearchDTO paymentSearch);
        List<Account> GetPayments(DateTime date);
    }
}
