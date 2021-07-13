using FamilyLoan.Domain.Core.Common;
using Sadr_Tools.ExtensionMethods;
using System;

namespace FamilyLoan.Domain.Core.Entities
{
    public  class LoanItem:BaseEntity
    {
        public LoanItem()
        {

        }
        public int ID{ get; set; }
        public int LoanID { get; set; }

        public double InstallmentAmount { get; set; }

        public DateTime InstallmentDate { get; set; }

        public  Loan Loan { get; set; }

        public   EnPaymentType PaymentType{ get; set; }
      
        public string PersianInstallmentDate=> InstallmentDate.ToPersianDate();
       
    }
}
