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
    public partial class Products_Edit : Form
    {
        public Products_Edit()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Products_Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.breadFantasyDataSet.Products);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
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

        private void add_Click(object sender, EventArgs e)
        {
            productsBindingSource.AddNew();
        }

        private void del_Click(object sender, EventArgs e)
        {
            productsBindingSource.RemoveCurrent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);
        }
    }
}
