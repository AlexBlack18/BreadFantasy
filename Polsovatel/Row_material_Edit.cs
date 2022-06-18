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
    public partial class Row_material_Edit : Form
    {
        public Row_material_Edit()
        {
            InitializeComponent();
        }

        private void raw_materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raw_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Row_material_Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Raw_material". При необходимости она может быть перемещена или удалена.
            this.raw_materialTableAdapter.Fill(this.breadFantasyDataSet.Raw_material);

        }

        private void first_Click(object sender, EventArgs e)
        {
            raw_materialBindingSource.MoveFirst();
        }

        private void last_Click(object sender, EventArgs e)
        {
            raw_materialBindingSource.MoveLast();
        }

        private void next_Click(object sender, EventArgs e)
        {
            raw_materialBindingSource.MoveNext();
        }

        private void lastnext_Click(object sender, EventArgs e)
        {
            raw_materialBindingSource.MovePrevious();
        }

        private void add_Click(object sender, EventArgs e)
        {
            raw_materialBindingSource.AddNew();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raw_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);
        }

        private void report_Click(object sender, EventArgs e)
        {
            Report_Row_materian report_Row_Materian = new Report_Row_materian();
            report_Row_Materian.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Close();
        }
    }
}
