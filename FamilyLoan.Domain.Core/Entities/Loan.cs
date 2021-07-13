using FamilyLoan.Domain.Core.Common;
using Sadr_Tools.ExtensionMethods;
using System;
using System.Collections.Generic;

namespace FamilyLoan.Domain.Core.Entities
{
    public class Loan : BaseEntity
    {

        public Loan()
        {

        }
        public int ID { get; set; }
        public int PersonID { get; set; }

        public byte PersonLoanNo { get; set; }

        public double TotalLoanAmount { get; set; }

        public double Installment { get; set; }

        public DateTime LoanDate { get; set; }


        public DateTime FirstInstallmentDate { get; set; }

        public DateTime LastInstallmentDate { get; set; }


        public bool IsFinished { get; set; }


        public EnPaymentType PaymentType { get; set; }

        public ICollection<LoanItem> LoanItems { get; }



        public string PersianLoanDate=> LoanDate.ToPersianDate();
        public string PersianFirstInstallmentDate => FirstInstallmentDate.ToPersianDate();
        public string PersianLastInstallmentDate=> LastInstallmentDate.ToPersianDate();

        public double InstallmentCount => TotalLoanAmount / Installment;




        public string LoanStatus => IsFinished ? "تسویه شده" : "تسویه نشده";

    }
}
