using System;
using System.Windows.Forms;

namespace TirupatiFinance
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Text = Constants.ApplicationName + " : Home";
            welcomeToolStripMenuItem.Text = "Welcome : " + Constants.UserName.ToUpper();

            if (Constants.isSystemUser)
            {
                adminToolStripMenuItem.Visible = true;
            }

            LocalizeForm();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality is not yet implemented.");
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.Text = Constants.ApplicationName + " : New Customer";
            newCustomer.ShowDialog();            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality is not yet implemented.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality is not yet implemented.");
        }

        private void LocalizeForm()
        {
            customerToolStripMenuItem.Text = Constants.resourceManager.GetString("Customer");
            newCustomerToolStripMenuItem.Text = Constants.resourceManager.GetString("New Customer");
            reportsToolStripMenuItem.Text = Constants.resourceManager.GetString("Reports");
            //dailyReportToolStripMenuItem.Text = Constants.resourceManager.GetString("Daily Report");
            customerInformationToolStripMenuItem.Text = Constants.resourceManager.GetString("Customer Information");
            dailyCollectionToolStripMenuItem.Text = Constants.resourceManager.GetString("Daily Collection");

        }

       
    }
}
