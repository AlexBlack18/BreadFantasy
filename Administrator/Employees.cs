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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.breadFantasyDataSet.Employees);

        }

        private void edit_Click(object sender, EventArgs e)
        {
            Employees_Edit employees_Edit = new Employees_Edit();
            employees_Edit.Show();
            this.Close();
        }

        private void first_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveFirst();
        }

        private void last_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveLast();
        }

        private void next_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveNext();
        }

        private void lastnext_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MovePrevious();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
