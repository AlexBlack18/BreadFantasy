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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Polsovatel.Customers polsovatel = new Polsovatel.Customers();
            polsovatel.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Polsovatel.Orders polsovatel = new Polsovatel.Orders();
            polsovatel.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Polsovatel.Raw_material polsovatel = new Polsovatel.Raw_material();
            polsovatel.Show();
            this.Close();
        }
    }
}
