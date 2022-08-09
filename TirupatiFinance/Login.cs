using System;
using System.Windows.Forms;

namespace TirupatiFinance
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Text = Constants.ApplicationName + " : Login";
            lblApplicationName.Text = Constants.ApplicationName;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            lblErrorMessage.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtUserName.Text == "a" && txtPassword.Text == "a")
            //{
            //MessageBox.Show("Your encrypted password is : " + Utility.Encrypt(txtUserName.Text, Constants.ApplicationName));

            Constants.UserName = txtUserName.Text;
            if (txtUserName.Text == "admin")
                Constants.isSystemUser = true;

            Utility.SetLanguage(Constants.Language.English);

            this.Hide();


            Home home = new Home();
            home.Show();
            //}
            //else { 
            //    lblErrorMessage.Visible = true;
            //}
        }

        private void lnkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This functionality is not yet implemented.");
        }
    }
}
