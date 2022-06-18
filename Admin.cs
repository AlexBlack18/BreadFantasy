using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadFantasy
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrator.Customers customers = new Administrator.Customers();
            customers.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Polsovatel.Suppliers suppliers = new Polsovatel.Suppliers();
            suppliers.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrator.Row_material row_Material = new Administrator.Row_material();
            row_Material.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Administrator.Orders orders = new Administrator.Orders();
            orders.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Administrator.Employees employees = new Administrator.Employees();
            employees.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Administrator.Products products = new Administrator.Products();
            products.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Administrator.Contracts contracts = new Administrator.Contracts();
            contracts.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Administrator.Salary salary = new Administrator.Salary();
            salary.Show();
            this.Close();
        }
    }
}
