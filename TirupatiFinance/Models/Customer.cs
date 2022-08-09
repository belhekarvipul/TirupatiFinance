using System;

namespace TirupatiFinance.Models
{
    public sealed class Customer
    {
        public int CustomerNumber { get; set; }
		public string CustomerName { get; set; }
		public string Address { get; set; }
		public string Contact1 { get; set; }
		public string Contact2 { get; set; }
		public DateTime LoanTakenDate { get; set; }
		public DateTime LoanCompletionDate { get; set; }
		public int TotalDuration { get; set; }
		public int TotalLoanAmount { get; set; }
		public int InstallmentAmount { get; set; }
		public string ReturnType { get; set; }
		public int RemainingAmount { get; set; }
		public string GuarantorName1 { get; set; }
		public string GuarantorAddress1 { get; set; }
		public string GuarantorContact1 { get; set; }
		public string GuarantorName2 { get; set; }
		public string GuarantorAddress2 { get; set; }
		public string GuarantorContact2 { get; set; }
		public bool LoanStatus { get; set; }
		public int CreatedBy { get; set; }
		public int UpdatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
