using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadFantasy.Administrator
{
    public partial class Customers_Edit : Form
    {
        public Customers_Edit()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Customers_Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.breadFantasyDataSet.Customers);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Close();
        }

        private void first_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveFirst();
        }

        private void last_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveLast();
        }

        private void next_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveNext();
        }

        private void lastnext_Click(object sender, EventArgs e)
        {
            customersBindingSource.MovePrevious();
        }

        private void add_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void del_Click(object sender, EventArgs e)
        {
            customersBindingSource.RemoveCurrent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);
        }
    }
}
