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
    public partial class Suppliers_Edit : Form
    {
        public Suppliers_Edit()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Suppliers_Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.breadFantasyDataSet.Suppliers);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();
            this.Close();
        }

        private void first_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveFirst();
        }

        private void last_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveLast();
        }

        private void next_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveNext();
        }

        private void lastnext_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MovePrevious();
        }

        private void add_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.AddNew();
        }

        private void del_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.RemoveCurrent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);
        }
    }
}
