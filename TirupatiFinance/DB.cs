using System;
using System.Data;
using TirupatiFinance.Models;

namespace TirupatiFinance
{
    public class DB
    {
        #region CUSTOMER
        public int AddCustomer(Customer customer)
        {
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

                var result = DbHelper.ExecuteInsert(query);

                if (result != null)
                    return Convert.ToInt32(result);
                return 0;
            }
            catch (Exception ex)
            {
                Utility.LogError(ex);
                return 0;
            }
        } 
        #endregion

        #region USER
        public int AddUser(User user)
        {
            try
            {
                string query = "INSERT INTO [dbo].[Users]("
                               + " [UserId]"
                               + ",[UserName]"
                               + ",[Address]"
                               + ",[Contact]"
                               + ",[Language]"
                               + ",[Role]"
                               + ",[Password]"
                               + ",[Status]) VALUES ("
                               + " '" + user.UserId + "'"
                               + ",'" + user.UserName + "'"
                               + ",'" + user.Address + "'"
                               + ",'" + user.Contact + "'"
                               + ",'" + user.Language + "'"
                               + ",'" + user.Role + "'"
                               + ",'" + Constants.DefaultPassword + "'"
                               + "," + (user.Status ? 1 : 0) + ");"
                             + "SELECT SCOPE_IDENTITY();";

                var result = DbHelper.ExecuteInsert(query);

                if (result != null)
                    return Convert.ToInt32(result);
                return 0;
            }
            catch (Exception ex)
            {
                Utility.LogError(ex);
                return 0;
            }
        }

        public int UpdateUser(User user)
        {
            try
            {
                string query = "UPDATE [dbo].[Users] SET"
                               + " [UserName] = '" + user.UserName + "'"
                               + ",[Address] = '" + user.Address + "'"
                               + ",[Contact] = '" + user.Contact + "'"
                               + ",[Language] = '" + user.Language + "'"
                               + ",[Role] = '" + user.Role + "'"
                               + ",[Status] = " + (user.Status ? 1 : 0)
                               + " WHERE [Id] = " + user.Id;

                var result = DbHelper.ExecuteUpdate(query);

                if (result != null)
                    return Convert.ToInt32(result);
                return 0;
            }
            catch (Exception ex)
            {
                Utility.LogError(ex);
                return 0;
            }
        }

        public DataTable SearchUser(string UserId, string UserName)
        {
            try
            {
                string query = "SELECT * FROM USERS WHERE  UserId = '" + UserId + "' OR UserName = '" + UserName + "'";
                var result = DbHelper.ExecuteSelect(query);
                if (result != null)
                    return result;
                else
                    return null;
            }
            catch (Exception ex)
            {
                Utility.LogError(ex);
                return null;
            }
        } 
        #endregion
    }
}
