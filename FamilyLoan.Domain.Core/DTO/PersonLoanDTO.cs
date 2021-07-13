namespace FamilyLoan.Domain.Core.DTO
{
    public class PersonLoanDTO
    {
        public string PersonFullName { get; set; }
        public byte LoanCode { get; set; }
        public string PersianLoanDate { get; set; }
        public string PersianLastInstallmentDate { get; set; }
        public double Amount { get; set; }
        public string LoanStatus { get; set; }

    }

}
