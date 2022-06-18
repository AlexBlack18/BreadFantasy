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
    public partial class Contracts : Form
    {
        public Contracts()
        {
            InitializeComponent();
        }

        private void contractsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Contracts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Contracts". При необходимости она может быть перемещена или удалена.
            this.contractsTableAdapter.Fill(this.breadFantasyDataSet.Contracts);

        }

        private void first_Click(object sender, EventArgs e)
        {
            contractsBindingSource.MoveFirst();
        }

        private void last_Click(object sender, EventArgs e)
        {
            contractsBindingSource.MoveLast();
        }

        private void next_Click(object sender, EventArgs e)
        {
            contractsBindingSource.MoveLast();
        }

        private void lastnext_Click(object sender, EventArgs e)
        {
            contractsBindingSource.MovePrevious();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Contracts_Edit contracts_Edit = new Contracts_Edit();
            contracts_Edit.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void датаToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.contractsTableAdapter.Дата(this.breadFantasyDataSet.Contracts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
