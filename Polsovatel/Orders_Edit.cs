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
    public partial class Orders_Edit : Form
    {
        public Orders_Edit()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Orders_Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.breadFantasyDataSet.Orders);

        }

        private void report_Click(object sender, EventArgs e)
        {
            Report_Orders report_Orders = new Report_Orders();
            report_Orders.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Close();
        }

        private void first_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveFirst();
        }

        private void last_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveLast();
        }

        private void next_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveNext();
        }

        private void lastnext_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MovePrevious();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ordersBindingSource.AddNew();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);
        }
    }
}
