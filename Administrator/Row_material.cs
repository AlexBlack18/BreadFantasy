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
    public partial class Row_material : Form
    {
        public Row_material()
        {
            InitializeComponent();
        }

        private void raw_materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.raw_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void Row_material_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "breadFantasyDataSet.Raw_material". При необходимости она может быть перемещена или удалена.
            this.raw_materialTableAdapter.Fill(this.breadFantasyDataSet.Raw_material);
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

        private void edit_Click(object sender, EventArgs e)
        {
            Row_material_Edit row_Material_Edit = new Row_material_Edit();
            row_Material_Edit.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void raw_materialBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.raw_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.breadFantasyDataSet);

        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void first_Click_1(object sender, EventArgs e)
        {
            raw_materialBindingSource.MoveFirst();
        }

        private void last_Click_1(object sender, EventArgs e)
        {
            raw_materialBindingSource.MoveLast();
        }

        private void next_Click_1(object sender, EventArgs e)
        {
            raw_materialBindingSource.MoveNext();
        }

        private void lastnext_Click_1(object sender, EventArgs e)
        {
            raw_materialBindingSource.MovePrevious();
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            Row_material_Edit row_Material_Edit = new Row_material_Edit();
            row_Material_Edit.Show();
            this.Close();
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
                case 3:
                    COL = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn6;
                    break;
            }
            //Блок If выполняет следующую операцию: если включён
            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать 
            //таблицу по полю заданному в переменной Col по возрастанию 
            //(pRODUCTSDataGridView.Sort (Col, System.ComponentModel.ListSortDirection. 
            //Ascending)), иначе по убыванию (pRODUCTSDataGridView.Sort (Col, System. 
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked)
                raw_materialDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Ascending);
            else
                raw_materialDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            raw_materialBindingSource.Filter = "Название='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            raw_materialBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и 
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть, 
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < raw_materialDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < raw_materialDataGridView.RowCount - 1; j++)
                {
                    raw_materialDataGridView[i, j].Style.BackColor = Color.White;
                    raw_materialDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они 
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них 
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < raw_materialDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < raw_materialDataGridView.RowCount - 1; j++)
                {
                    if (raw_materialDataGridView[i,
                   j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        raw_materialDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        raw_materialDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void вес___2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.raw_materialTableAdapter.Вес___2(this.breadFantasyDataSet.Raw_material);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
