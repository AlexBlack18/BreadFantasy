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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Close();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Suppliers_Edit suppliers = new Suppliers_Edit();
            suppliers.Show();
            this.Close ();
        }

        private void lastnext_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveLast();
        }

        private void next_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveNext();
        }

        private void last_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MovePrevious();
        }

        private void first_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveFirst();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.breadFantasyDataSet.Suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.breadFantasyDataSet.Suppliers);

        }

        private void suppliersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void suppliersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }
    }
}
