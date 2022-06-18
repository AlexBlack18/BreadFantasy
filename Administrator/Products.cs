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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.breadFantasyDataSet.Products);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void first_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveFirst();
        }

        private void last_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveLast();
        }

        private void next_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }

        private void lastnext_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Products_Edit products_Edit = new Products_Edit();
            products_Edit.Show();
            this.Close();
        }

        private void смена_2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Смена_2(this.breadFantasyDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
