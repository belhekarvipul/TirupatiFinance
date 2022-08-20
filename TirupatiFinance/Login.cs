using System;
using System.Data;
using System.Windows.Forms;

namespace TirupatiFinance
{
    public partial class Login : Form
    {
        DB db = new DB();
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
            if (txtUserName.Text != string.Empty && txtPassword.Text != string.Empty )
            {
                //MessageBox.Show("Your encrypted password is : " + Utility.Encrypt(txtUserName.Text, Constants.ApplicationName));
                DataTable userDetails = db.Userlogin(txtUserName.Text, txtPassword.Text);
                Constants.UserName = txtUserName.Text;
                foreach (DataRow row in userDetails.Rows)
                {
                    string UserName = row["UserName"].ToString();
                    string Language = row["Language"].ToString();

                       if (UserName == "Admin")
                        Constants.isSystemUser = true;
                       if (Language == "Marathi")
                        Utility.SetLanguage(Constants.Language.Marathi);
                       if(Language == "English")
                        Utility.SetLanguage(Constants.Language.English);
                       if (Language == "Hindi")
                        Utility.SetLanguage(Constants.Language.Hindi);
                }

            this.Hide();


            Home home = new Home();
            home.Show();

            }
            else
            {
                lblErrorMessage.Visible = true;
            }
        }

        private void lnkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This functionality is not yet implemented.");
        }
    }
}
