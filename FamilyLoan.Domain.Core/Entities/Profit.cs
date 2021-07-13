using FamilyLoan.Domain.Core.Common;
using System;

namespace FamilyLoan.Domain.Core.Entities
{
    public  class Profit:BaseEntity
    {
        public Profit()
        {
                
        }
        public int ID{ get; set; }
        public string Description { get; set; }
        public  double ProfitAmount { get; set; }
        public DateTime ProfitDate{ get; set; }
        public   EnPaymentType PaymentType { get; set; }


    }
}
