﻿using System;
using System.Windows.Forms;

namespace TirupatiFinance
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Text = Constants.ApplicationName + " : Home";
            welcomeToolStripMenuItem.Text = "Welcome : " + Constants.loggedInUser.UserName.ToUpper();

            if (Constants.loggedInUser.Role == Constants.Role.Admin.ToString())
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
            NewUser newUser = new NewUser();
            newUser.Text = Constants.ApplicationName + " : New User";
            newUser.ShowDialog();
        }

        private void LocalizeForm()
        {
            customerToolStripMenuItem.Text = Constants.resourceManager.GetString("Customer");
            newCustomerToolStripMenuItem.Text = Constants.resourceManager.GetString("New Customer");
            reportsToolStripMenuItem.Text = Constants.resourceManager.GetString("Reports");
            dailyReportToolStripMenuItem.Text = Constants.resourceManager.GetString("Daily Report");
            manageCustomerToolStripMenuItem.Text = Constants.resourceManager.GetString("Manage Customer");
            dailyCollectionToolStripMenuItem.Text = Constants.resourceManager.GetString("Daily Collection");
        }

        private void backupNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.GenerateBackup())
                MessageBox.Show("Backup generated successfully.");
            else
                MessageBox.Show("Something went wrong! Try again after sometime or contact your administrator.");
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Text = Constants.ApplicationName + " : Manage User";
            manageUser.ShowDialog();
        }

        private void dailyCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyCollection dailyCollection = new DailyCollection();
            dailyCollection.Text = Constants.ApplicationName + " : Daily Collection";
            dailyCollection.ShowDialog();
        }
    }
}
