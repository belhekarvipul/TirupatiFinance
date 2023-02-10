using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TirupatiFinance
{
    public partial class DailyCollection : Form
    {
        DB db = new DB();
        public DailyCollection()
        {
            InitializeComponent();
            tabPanelDailyCollection.SelectedTab = tabDaily;
            BuildDailyCollectionGrid(Constants.ReturnType.Daily.ToString(), dataGridDaily);
        }

        private void tabPanelDailyCollection_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    BuildDailyCollectionGrid(Constants.ReturnType.Daily.ToString(), dataGridDaily);
                    break;
                case 1:
                    BuildDailyCollectionGrid(Constants.ReturnType.Weekly.ToString(), dataGridWeekly);
                    break;

                case 2:
                    BuildDailyCollectionGrid(Constants.ReturnType.Monyhly.ToString(), dataGridMonthly);
                    break;
            }
        }

        private void BuildDailyCollectionGrid(string returnType, DataGridView dataGrid) {
            DataTable dtSource = new DataTable();

            DataColumn dc = new DataColumn();
            dc.DataType = typeof(string);
            dc.ReadOnly = true;
            dc.ColumnName = "Customer Number";
            dtSource.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = typeof(string);
            dc.ReadOnly = true;
            dc.ColumnName = "Customer Name";
            dtSource.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = typeof(string);
            dc.ReadOnly = true;
            dc.ColumnName = "Total Loan Amount";
            dtSource.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = typeof(string);
            dc.ReadOnly = true;
            dc.ColumnName = "Remaining Amount";
            dtSource.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = typeof(string);
            dc.ReadOnly = true;
            dc.ColumnName = "Installment Amount";
            dtSource.Columns.Add(dc);

            DataColumn dcReceived = new DataColumn();
            dcReceived.ColumnName = "Received";
            //dcReceived.DataType = typeof(string);
            

            TextBox tb = new TextBox();
            tb.Text = "Enter amount here";
            
            dcReceived.Container.Add(tb);

            dtSource.Columns.Add(dcReceived);

            DataTable dtResult = db.GetDailyCollectionData(returnType);

            if (dtResult != null && dtResult.Rows.Count > 0) {
                foreach (DataRow row in dtResult.Rows) {
                    DataRow newDataRow = dtSource.NewRow();
                    newDataRow["Customer Number"] = row["CustomerNumber"];
                    newDataRow["Customer Name"] = row["CustomerName"];
                    newDataRow["Total Loan Amount"] = row["TotalLoanAmount"];
                    newDataRow["Remaining Amount"] = row["RemainingAmount"];
                    newDataRow["Installment Amount"] = row["InstallmentAmount"];
                    dtSource.Rows.Add(newDataRow);
                }
            }

            dataGrid.DataSource = dtSource;
        }
    }
}
