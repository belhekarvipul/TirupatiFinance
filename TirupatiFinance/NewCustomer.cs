using System;
using System.Windows.Forms;
using TirupatiFinance.Models;

namespace TirupatiFinance
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
            BindReturnType();
            LocalizeForm();
        }

        #region PRIVATE
        private void LocalizeForm()
        {
            lblCustomerInformation.Text = Constants.resourceManager.GetString("Customer Information");
            lblCustomerName.Text = Constants.resourceManager.GetString("Customer Name");
            lblCustomerNumber.Text = Constants.resourceManager.GetString("Customer Number");
            lblAddress.Text = Constants.resourceManager.GetString("Address");
            lblContact1.Text = Constants.resourceManager.GetString("Contact 1");
            lblContact2.Text = Constants.resourceManager.GetString("Contact 2");
            lblReturnType.Text = Constants.resourceManager.GetString("Return Type");
            lblTotalLoanAmount.Text = Constants.resourceManager.GetString("Total Loan Amount");
            lblInstallmentAmount.Text = Constants.resourceManager.GetString("Installment Amount");
            lblLoanTakenDate.Text = Constants.resourceManager.GetString("Loan Taken Date");
            lblLoanCompletionDate.Text = Constants.resourceManager.GetString("Loan Completion Date");
            lblTotalDuration.Text = Constants.resourceManager.GetString("Total Duration");
            lblDailyMonthlyYearly.Text = Constants.resourceManager.GetString("(Daily/Monthly/Yearly)");

            lblGuarantorInformation.Text = Constants.resourceManager.GetString("Guarantor Information");
            
            lblGuarantorName1.Text = Constants.resourceManager.GetString("Guarantor Name 1");
            lblGuarantorAddress1.Text = Constants.resourceManager.GetString("Address");
            lblGuarantorContact1.Text = Constants.resourceManager.GetString("Contact");

            lblGuarantorName2.Text = Constants.resourceManager.GetString("Guarantor Name 2");
            lblGuarantorAddress2.Text = Constants.resourceManager.GetString("Address");
            lblGuarantorContact2.Text = Constants.resourceManager.GetString("Contact");

            btnReset.Text = Constants.resourceManager.GetString("Reset");
            btnSave.Text = Constants.resourceManager.GetString("Save");
            btnClose.Text = Constants.resourceManager.GetString("Close");
        }

        private void BindReturnType()
        {
            ddlReturnType.Items.Clear();
            ddlReturnType.Items.Add("-- Select --");
            ddlReturnType.Items.Add(Constants.ReturnType.Daily);
            ddlReturnType.Items.Add(Constants.ReturnType.Weekly);
            ddlReturnType.Items.Add(Constants.ReturnType.Monyhly);
            ddlReturnType.Items.Add(Constants.ReturnType.Yearly);
            ddlReturnType.SelectedIndex = 0;
        }

        private void ResetControls()
        {
            txtCustomerName.Text = string.Empty;
            txtCustomerNumber.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContact1.Text = string.Empty;
            txtContact2.Text = string.Empty;
            ddlReturnType.SelectedIndex = 0;
            txtTotalLoanAmount.Text = string.Empty;
            txtInstallmentAmount.Text = string.Empty;
            txtTotalDuration.Text = string.Empty;
            txtLoanTakenDate.Text = string.Empty;
            txtLoanCompletionDate.Text = string.Empty;
            txtGuarantorName1.Text = string.Empty;
            txtGuarantorAddress1.Text = string.Empty;
            txtGuarantorContact1.Text = string.Empty;
            txtGuarantorName2.Text = string.Empty;
            txtGuarantorAddress2.Text = string.Empty;
            txtGuarantorContact2.Text = string.Empty;
        }

        private bool ValidateCustomer()
        {
            return true;
        }
        #endregion

        #region ACTIONS
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm Close", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateCustomer())
            {
                Customer customer = new Customer();
                customer.CustomerName = txtCustomerName.Text;
                customer.Address = txtAddress.Text;
                customer.Contact1 = txtContact1.Text;
                customer.Contact2 = txtContact2.Text;
                customer.ReturnType = ddlReturnType.SelectedItem.ToString();
                customer.TotalLoanAmount = Convert.ToInt32(txtTotalLoanAmount.Text);
                customer.InstallmentAmount = Convert.ToInt32(txtInstallmentAmount.Text);
                customer.TotalDuration = Convert.ToInt32(txtTotalDuration.Text);
                customer.LoanTakenDate = Convert.ToDateTime(txtLoanTakenDate.Text);
                customer.LoanCompletionDate = Convert.ToDateTime(txtLoanCompletionDate.Text);
                customer.GuarantorName1 = txtGuarantorName1.Text;
                customer.GuarantorAddress1 = txtGuarantorAddress1.Text;
                customer.GuarantorContact1 = txtGuarantorContact1.Text;
                customer.GuarantorName2 = txtGuarantorName2.Text;
                customer.GuarantorAddress2 = txtGuarantorAddress2.Text;
                customer.GuarantorContact2 = txtGuarantorContact2.Text;

                DB db = new DB();
                int CustomerId = db.AddCustomer(customer);

                if (CustomerId > 0)
                {
                    MessageBox.Show("A new customer with Id - " + CustomerId + " has been added to the system.");
                    ResetControls();
                }
                else
                    MessageBox.Show("Something went wrong! Try again after sometime or contact your administrator.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
        #endregion
    }
}
