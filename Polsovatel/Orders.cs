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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Close();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.breadFantasyDataSet.Orders);

        }

        private void first_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveFirst();
        }

        private void last_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveLast();
        }

        private void next_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveNext();
        }

        private void lastnext_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MovePrevious();
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
            }
            //Блок If выполняет следующую операцию: если включён
            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать 
            //таблицу по полю заданному в переменной Col по возрастанию 
            //(pRODUCTSDataGridView.Sort (Col, System.ComponentModel.ListSortDirection. 
            //Ascending)), иначе по убыванию (pRODUCTSDataGridView.Sort (Col, System. 
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked)
                ordersDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Ascending);
            else
                ordersDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordersBindingSource.Filter = "Состояние='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ordersBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и 
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть, 
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < ordersDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < ordersDataGridView.RowCount - 1; j++)
                {
                    ordersDataGridView[i, j].Style.BackColor = Color.White;
                    ordersDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они 
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них 
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < ordersDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < ordersDataGridView.RowCount - 1; j++)
                {
                    if (ordersDataGridView[i,
                   j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        ordersDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        ordersDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Orders_Edit orders_Edit = new Orders_Edit();
            orders_Edit.Show();
            this.Close();
        }
    }
}
