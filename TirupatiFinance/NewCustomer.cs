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
            InitializeControls(false);
        }

        #region PRIVATE
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

        private void InitializeControls(bool flag)
        {
            btnSave.Enabled = !flag;
            btnDelete.Enabled = flag;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
                    MessageBox.Show("A new customer with Id - " + CustomerId + "has been added to the system.");
                else
                    MessageBox.Show("Something went wrong! Try again after sometime or contact your administrator.");
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
        #endregion
    }
}
