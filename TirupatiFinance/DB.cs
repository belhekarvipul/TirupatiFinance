using System;
using TirupatiFinance.Models;

namespace TirupatiFinance
{
    public class DB
    {
        public int AddCustomer(Customer customer) {
            try
            {
                string query = "INSERT INTO[dbo].[Customers] ("
                             + "[CustomerName]"
                             + ",[Address]"
                             + ",[Contact1]"
                             + ",[Contact2]"
                             + ",[LoanTakenDate]"
                             + ",[LoanCompletionDate]"
                             + ",[TotalDuration]"
                             + ",[TotalLoanAmount]"
                             + ",[InstallmentAmount]"
                             + ",[ReturnType]"
                             + ",[RemainingAmount]"
                             + ",[GuarantorName1]"
                             + ",[GuarantorAddress1]"
                             + ",[GuarantorContact1]"
                             + ",[GuarantorName2]"
                             + ",[GuarantorAddress2]"
                             + ",[GuarantorContact2]"
                             + ",[LoanStatus]"
                             + ",[CreatedBy]"
                             + ",[UpdatedBy]"
                             + ",[CreatedDate]"
                             + ",[UpdatedDate]) VALUES ("
                             + "'" + customer.CustomerName + "'"
                             + ",'" + customer.Address + "'"
                             + ",'" + customer.Contact1 + "'"
                             + ",'" + customer.Contact2 + "'"
                             + ",'" + customer.LoanTakenDate + "'"
                             + ",'" + customer.LoanCompletionDate + "'"
                             + "," + customer.TotalDuration
                             + "," + customer.TotalLoanAmount
                             + "," + customer.InstallmentAmount
                             + ",'" + customer.ReturnType + "'"
                             + "," + customer.TotalLoanAmount
                             + ",'" + customer.GuarantorName1 + "'"
                             + ",'" + customer.GuarantorAddress1 + "'"
                             + ",'" + customer.GuarantorContact1 + "'"
                             + ",'" + customer.GuarantorName2 + "'"
                             + ",'" + customer.GuarantorAddress2 + "'"
                             + ",'" + customer.GuarantorContact2 + "'"
                             + ",1"
                             + ",1"
                             + ",1"
                             + ",GETDATE(),GETDATE());"
                             + "SELECT SCOPE_IDENTITY();";

                var result = DbHelper.ExecuteSQL(query);

                if (result != null)
                    return Convert.ToInt32(result);
                return 0;
            }
            catch (Exception ex)
            {
                Utility.log.Error("Error Message : " + ex.Message + Environment.NewLine + "Stace Trace : " + ex.StackTrace);
                return 0;
            }
        }
    }
}
