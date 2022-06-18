using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadFantasy.Polsovatel
{
    public partial class Report_Orders : Form
    {
        public Report_Orders()
        {
            InitializeComponent();
        }

        private void Report_Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.breadFantasyDataSet.Orders);

            this.reportViewer1.RefreshReport();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Orders_Edit orders_Edit = new Orders_Edit();
            orders_Edit.Show();
            this.Close();
        }
    }
}
