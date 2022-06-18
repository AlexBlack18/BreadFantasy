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
    public partial class Report_Row_materian : Form
    {
        public Report_Row_materian()
        {
            InitializeComponent();
        }

        private void Report_Row_materian_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Raw_material". При необходимости она может быть перемещена или удалена.
            this.raw_materialTableAdapter.Fill(this.breadFantasyDataSet.Raw_material);

            this.reportViewer1.RefreshReport();
        }
    }
}
