using System;
using System.Data;
using System.Windows.Forms;
using TirupatiFinance.Models;

namespace TirupatiFinance
{
    public partial class ManageUser : Form
    {
        DB db = new DB();
        public ManageUser()
        {
            InitializeComponent();
        }

        private void BindRole()
        {
            ddlRole.Items.Clear();
            ddlRole.Items.Add(Constants.Role.Admin);
            ddlRole.Items.Add(Constants.Role.NonAdmin);
            ddlRole.SelectedItem = Constants.Role.NonAdmin;
        }
        private void BindLanguage()
        {
            ddlLanguage.Items.Clear();
            ddlLanguage.Items.Add(Constants.Language.English);
            ddlLanguage.Items.Add(Constants.Language.Marathi);
            ddlLanguage.Items.Add(Constants.Language.Hindi);
            ddlLanguage.SelectedIndex = 0;
        }

        private void ResetControls() {
            txtUserIdSearch.Text = "";
            txtUserNameSearch.Text = "";
            lblId.Text = "";
            txtUserId.Text = "";
            txtUserName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            BindLanguage();
            BindRole();
            radioActive.Checked = true;
        }

        #region Actions
        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = Convert.ToInt32(lblId.Text);
            user.UserId = txtUserId.Text;
            user.UserName = txtUserName.Text;
            user.Address = txtAddress.Text;
            user.Contact = txtContact.Text;
            user.Language = ddlLanguage.SelectedItem.ToString();
            user.Role = ddlRole.SelectedItem.ToString();

            if (radioActive.Checked)
                user.Status = true;
            else
                user.Status &= false;

            int result = db.UpdateUser(user);

            if (result > 0)
            {
                MessageBox.Show("User details has been updated to the system.");
                ResetControls();
            }
            else
                MessageBox.Show("Something went wrong! Try again after sometime or contact your administrator.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable user = db.SearchUser(txtUserIdSearch.Text, txtUserNameSearch.Text);
            if (user != null && user.Rows.Count > 0) 
            {
                if (user.Rows.Count > 1)
                {
                    MessageBox.Show("No user found with this details.");
                }
                else {
                    BindLanguage();
                    BindRole();
                    lblId.Text = user.Rows[0]["Id"].ToString();
                    txtUserId.Text = user.Rows[0]["UserId"].ToString();
                    txtUserName.Text = user.Rows[0]["UserName"].ToString();
                    txtAddress.Text = user.Rows[0]["Address"].ToString();
                    txtContact.Text = user.Rows[0]["Contact"].ToString();                    
                    ddlLanguage.SelectedIndex = ddlLanguage.FindString(user.Rows[0]["Language"].ToString());
                    ddlRole.SelectedIndex = ddlRole.FindString(user.Rows[0]["Role"].ToString());

                    if ((bool)user.Rows[0]["Status"])
                        radioActive.Checked = true;
                    else
                        radioInactive.Checked = true;
                }            
            }
            else
            {
                MessageBox.Show("No user found with this details.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
