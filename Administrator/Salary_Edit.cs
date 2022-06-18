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
    public partial class Salary_Edit : Form
    {
        public Salary_Edit()
        {
            InitializeComponent();
        }

        private void salaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Salary_Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Salary". При необходимости она может быть перемещена или удалена.
            this.salaryTableAdapter.Fill(this.breadFantasyDataSet.Salary);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.Show();
            this.Close();
        }

        private void first_Click(object sender, EventArgs e)
        {
            salaryBindingSource.MoveFirst();
        }

        private void last_Click(object sender, EventArgs e)
        {
            salaryBindingSource.MoveLast();
        }

        private void next_Click(object sender, EventArgs e)
        {
            salaryBindingSource.MoveNext();
        }

        private void lastnext_Click(object sender, EventArgs e)
        {
            salaryBindingSource.MovePrevious();
        }

        private void add_Click(object sender, EventArgs e)
        {
            salaryBindingSource.AddNew();
        }

        private void del_Click(object sender, EventArgs e)
        {
            salaryBindingSource.RemoveCurrent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);
        }
    }
}
