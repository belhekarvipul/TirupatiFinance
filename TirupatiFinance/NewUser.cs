using System;
using System.Windows.Forms;

namespace TirupatiFinance
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
            LocalizeForm();
            BindRole();
            BindLanguage();
        }

        #region Private
        private void LocalizeForm()
        {
            lblAddress.Text = Constants.resourceManager.GetString("Address");
            lblContact.Text = Constants.resourceManager.GetString("Contact");

            btnClose.Text = Constants.resourceManager.GetString("Close");
            btnReset.Text = Constants.resourceManager.GetString("Reset");
            btnSave.Text = Constants.resourceManager.GetString("Save");
        }
        private void BindRole() { }
        private void BindLanguage() {
            ddlLanguage.Items.Clear();
            ddlLanguage.Items.Add(Constants.Language.English);
            ddlLanguage.Items.Add(Constants.Language.Marathi);
            ddlLanguage.Items.Add(Constants.Language.Hindi);
            ddlLanguage.SelectedIndex = 0;
        }
        private bool ValidateUser()
        {
            return true;
        }
        #endregion

        #region ACTIONS
        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (ValidateCustomer())
            //{
            //    Customer customer = new Customer();
            //    customer.CustomerName = txtCustomerName.Text;
            //    customer.Address = txtAddress.Text;
            //    customer.Contact1 = txtContact1.Text;
            //    customer.Contact2 = txtContact2.Text;
            //    customer.ReturnType = ddlReturnType.SelectedItem.ToString();
            //    customer.TotalLoanAmount = Convert.ToInt32(txtTotalLoanAmount.Text);
            //    customer.InstallmentAmount = Convert.ToInt32(txtInstallmentAmount.Text);
            //    customer.TotalDuration = Convert.ToInt32(txtTotalDuration.Text);
            //    customer.LoanTakenDate = Convert.ToDateTime(txtLoanTakenDate.Text);
            //    customer.LoanCompletionDate = Convert.ToDateTime(txtLoanCompletionDate.Text);
            //    customer.GuarantorName1 = txtGuarantorName1.Text;
            //    customer.GuarantorAddress1 = txtGuarantorAddress1.Text;
            //    customer.GuarantorContact1 = txtGuarantorContact1.Text;
            //    customer.GuarantorName2 = txtGuarantorName2.Text;
            //    customer.GuarantorAddress2 = txtGuarantorAddress2.Text;
            //    customer.GuarantorContact2 = txtGuarantorContact2.Text;

            //    DB db = new DB();
            //    int CustomerId = db.AddCustomer(customer);

            //    if (CustomerId > 0)
            //        MessageBox.Show("A new customer with Id - " + CustomerId + " has been added to the system.");
            //    else
            //        MessageBox.Show("Something went wrong! Try again after sometime or contact your administrator.");
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
