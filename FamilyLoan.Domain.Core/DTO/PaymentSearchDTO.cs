using System;

namespace FamilyLoan.Domain.Core.DTO
{
    public class PaymentSearchDTO
    {

        public int? PersonID { get; set; }
        public byte? PaymentTypeCode { get; set; }
        public double? FromAmount { get; set; }
        public double? ToAmount { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }

}
