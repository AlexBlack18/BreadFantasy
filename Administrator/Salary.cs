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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void salaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Salary". При необходимости она может быть перемещена или удалена.
            this.salaryTableAdapter.Fill(this.breadFantasyDataSet.Salary);

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

        private void edit_Click(object sender, EventArgs e)
        {
            Salary_Edit salary_Edit = new Salary_Edit();
            salary_Edit.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void salaryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private System.Windows.Forms.DataGridViewColumn COL;

        private void button1_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            COL = new System.Windows.Forms.DataGridViewColumn();

            //блок switch, присваивающий в 
            //переменную Col имя выбранного столбца таблицы в зависимости от номера 
            //выбранного пункта списка (ListBox1.SelectedIndex). Если выбран первый пункт 
            //списка, то в переменную Col записывается столбец 
            //DataGridViewTextBoxColumn2, если второй, то – DataGridViewTextBoxColumn3 
            //и так далее. Хотелось бы отметить тот факт, что нумерация пунктов списка 
            //начинается с нуля, а нумерация столбцов с единицы. Первый столбец «Наименование» 
            //носит имя DataGridViewTextBoxColumn2, так как имя 
            //DataGridViewTextBoxColumn1 имеет столбец заголовков строк; 

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn4;
                    break;
            }
            //Блок If выполняет следующую операцию: если включён
            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать 
            //таблицу по полю заданному в переменной Col по возрастанию 
            //(pRODUCTSDataGridView.Sort (Col, System.ComponentModel.ListSortDirection. 
            //Ascending)), иначе по убыванию (pRODUCTSDataGridView.Sort (Col, System. 
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked)
                salaryDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Ascending);
            else
                salaryDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salaryBindingSource.Filter = "Зарплата='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salaryBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и 
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть, 
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < salaryDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < salaryDataGridView.RowCount - 1; j++)
                {
                    salaryDataGridView[i, j].Style.BackColor = Color.White;
                    salaryDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они 
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них 
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < salaryDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < salaryDataGridView.RowCount - 1; j++)
                {
                    if (salaryDataGridView[i,
                   j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        salaryDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        salaryDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void премия___1000ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.salaryTableAdapter.Премия___1000(this.breadFantasyDataSet.Salary);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
