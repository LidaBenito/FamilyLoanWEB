using FamilyLoan.Domain.Core.Entities;
using System.Collections.Generic;

namespace FamilyLoan.Domain.Contacts.Services
{
    public interface BankService
    {
        float GetSumBanks(List<Bank> banks);
        float GetSumAccounts(List<Account> accounts);
        float GetSumLoans(List<Loan> loans);
        float GetSumProfit(List<Profit>  profits);

    }
}
