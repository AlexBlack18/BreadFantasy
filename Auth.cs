using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BreadFantasy
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-PPVVDQM\SQLEXPRESS;Initial Catalog=BreadFantasy;Integrated Security=True");
            string query = "Select * from [Authorization] where Login = '" + login.Text.Trim() + "' and Password = '" + password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                if (login.Text == "admin" && password.Text == "admin")
                {
                    Admin f2 = new Admin();
                    f2.Show();
                    this.Close();
                }

                else
                {
                    User f2 = new User();
                    f2.Show();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Не верно введен логин или пароль");
                password.Clear();
                login.Clear();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Authorization". При необходимости она может быть перемещена или удалена.
            this.authorizationTableAdapter.Fill(this.breadFantasyDataSet.Authorization);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBox1.Checked)
                {
                    password.UseSystemPasswordChar = false;
                }
                else
                {
                    password.UseSystemPasswordChar = true;
                }
        }

        private void checkBox1_Enter(object sender, EventArgs e)
        {
            password.Focus();
        }
    }
}
