using FamilyLoan.Domain.Core.Common;
using System;

namespace FamilyLoan.Domain.Core.Entities
{
    public class Account:BaseEntity
    {
        public Account()
        {

        }
        public int ID { get; set; }
        public double Amount{ get; set; }
        public double TotalAmount{ get; set; }
        public string Description{ get; set; }
        public DateTime EntryDate{ get; set; }
        public Person person { get; set; }
        public  EnPaymentType PaymentType { get; set; }

    }
}
