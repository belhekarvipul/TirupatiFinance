using System;
using System.Data;
using System.Windows.Forms;
using TirupatiFinance.Models;

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
            if (txtUserName.Text != string.Empty || txtPassword.Text != string.Empty)
            {
                DataTable dtUser = db.Userlogin(txtUserName.Text, txtPassword.Text);

                if (dtUser != null && dtUser.Rows.Count > 0)
                {
                    User loggedInUser = new User();

                    loggedInUser.Id = Convert.ToInt32(dtUser.Rows[0]["Id"]);
                    loggedInUser.UserId = dtUser.Rows[0]["UserId"].ToString();
                    loggedInUser.UserName = dtUser.Rows[0]["UserName"].ToString();
                    loggedInUser.Address = dtUser.Rows[0]["Address"].ToString();
                    loggedInUser.Contact = dtUser.Rows[0]["Contact"].ToString();
                    loggedInUser.Language = dtUser.Rows[0]["Language"].ToString();
                    loggedInUser.Password = dtUser.Rows[0]["Password"].ToString();
                    loggedInUser.Role = dtUser.Rows[0]["Role"].ToString();
                    loggedInUser.Status = true;

                    Constants.loggedInUser = loggedInUser;

                    switch (loggedInUser.Language)
                    {
                        case "Marathi":
                            Utility.SetLanguage(Constants.Language.Marathi);
                            break;
                        case "English":
                            Utility.SetLanguage(Constants.Language.English);
                            break;
                        case "Hindi":
                            Utility.SetLanguage(Constants.Language.Hindi);
                            break;
                        default:
                            Utility.SetLanguage(Constants.Language.English);
                            break;
                    }

                    this.Hide();
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    lblErrorMessage.Text = "Please enter correct details.";
                    lblErrorMessage.Visible = true;
                }
            }
            else
            {
                lblErrorMessage.Text = "Please enter UserId and Password.";
                lblErrorMessage.Visible = true;
            }
        }

        private void lnkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This functionality is not yet implemented.");
        }
    }
}
