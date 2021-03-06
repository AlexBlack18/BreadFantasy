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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.breadFantasyDataSet.Customers);

        }

        private void edit_Click(object sender, EventArgs e)
        {
            Customers_Edit customers_Edit = new Customers_Edit();
            customers_Edit.Show();
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

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void имя___ЕленаToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.Имя___Елена(this.breadFantasyDataSet.Customers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
