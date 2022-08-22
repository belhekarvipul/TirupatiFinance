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
            dataGrid.DataSource = db.GetDailyCollectionData(returnType);
        }
    }
}
