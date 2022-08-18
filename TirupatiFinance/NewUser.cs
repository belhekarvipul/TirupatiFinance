using System;
using System.Windows.Forms;
using TirupatiFinance.Models;

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
        }
        private void BindRole() {
            ddlRole.Items.Clear();
            ddlRole.Items.Add(Constants.Role.Admin);
            ddlRole.Items.Add(Constants.Role.NonAdmin);
            ddlRole.SelectedItem = Constants.Role.NonAdmin;
        }
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
        private void ResetControls() {
            txtUserId.Text = "";
            txtUserName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            BindRole();
            BindLanguage();
            radioInactive.Checked = true;
        }
        #endregion

        #region ACTIONS
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUser())
            {
                User user = new User();
                user.UserId = txtUserId.Text;
                user.UserName = txtUserName.Text;
                user.Address = txtAddress.Text;
                user.Contact = txtContact.Text;
                user.Role = ddlRole.SelectedItem.ToString();
                user.Language = ddlLanguage.SelectedItem.ToString();
                if (radioActive.Checked)
                    user.Status = true;
                else
                    user.Status &= false;

                DB db = new DB();
                int UserId = db.AddUser(user);

                if (UserId > 0)
                {
                    MessageBox.Show("A new user with Id - " + UserId + " has been added to the system.");
                    ResetControls();
                }
                else
                    MessageBox.Show("Something went wrong! Try again after sometime or contact your administrator.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
