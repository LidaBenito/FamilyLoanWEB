using FamilyLoan.Domain.Core.Common;
using System;

namespace FamilyLoan.Domain.Core.Entities
{
    public class Bank:BaseEntity
    {
        public Bank()
        {

        }
        public int ID{ get; set; }
        public DateTime AmountDate{ get; set; }
        public string  Description{ get; set; }
    }
}
