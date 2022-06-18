namespace BreadFantasy.Administrator
{
    partial class Salary_Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label премияLabel;
            System.Windows.Forms.Label зарплатаLabel;
            System.Windows.Forms.Label итого_к_выплатеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary_Edit));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.breadFantasyDataSet = new BreadFantasy.BreadFantasyDataSet();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryTableAdapter = new BreadFantasy.BreadFantasyDataSetTableAdapters.SalaryTableAdapter();
            this.tableAdapterManager = new BreadFantasy.BreadFantasyDataSetTableAdapters.TableAdapterManager();
            this.salaryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salaryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.премияTextBox = new System.Windows.Forms.TextBox();
            this.зарплатаTextBox = new System.Windows.Forms.TextBox();
            this.итого_к_выплатеTextBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.lastnext = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Button();
            премияLabel = new System.Windows.Forms.Label();
            зарплатаLabel = new System.Windows.Forms.Label();
            итого_к_выплатеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadFantasyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingNavigator)).BeginInit();
            this.salaryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // премияLabel
            // 
            премияLabel.AutoSize = true;
            премияLabel.BackColor = System.Drawing.Color.Transparent;
            премияLabel.Location = new System.Drawing.Point(378, 280);
            премияLabel.Name = "премияLabel";
            премияLabel.Size = new System.Drawing.Size(50, 13);
            премияLabel.TabIndex = 93;
            премияLabel.Text = "Премия:";
            // 
            // зарплатаLabel
            // 
            зарплатаLabel.AutoSize = true;
            зарплатаLabel.BackColor = System.Drawing.Color.Transparent;
            зарплатаLabel.Location = new System.Drawing.Point(370, 306);
            зарплатаLabel.Name = "зарплатаLabel";
            зарплатаLabel.Size = new System.Drawing.Size(58, 13);
            зарплатаLabel.TabIndex = 94;
            зарплатаLabel.Text = "Зарплата:";
            // 
            // итого_к_выплатеLabel
            // 
            итого_к_выплатеLabel.AutoSize = true;
            итого_к_выплатеLabel.BackColor = System.Drawing.Color.Transparent;
            итого_к_выплатеLabel.Location = new System.Drawing.Point(333, 332);
            итого_к_выплатеLabel.Name = "итого_к_выплатеLabel";
            итого_к_выплатеLabel.Size = new System.Drawing.Size(95, 13);
            итого_к_выплатеLabel.TabIndex = 95;
            итого_к_выплатеLabel.Text = "Итого к выплате:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BreadFantasy.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(297, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 62);
            this.label3.TabIndex = 91;
            this.label3.Text = "BreadFantasy";
            // 
            // breadFantasyDataSet
            // 
            this.breadFantasyDataSet.DataSetName = "BreadFantasyDataSet";
            this.breadFantasyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "Salary";
            this.salaryBindingSource.DataSource = this.breadFantasyDataSet;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorizationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.Raw_materialTableAdapter = null;
            this.tableAdapterManager.SalaryTableAdapter = this.salaryTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BreadFantasy.BreadFantasyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salaryBindingNavigator
            // 
            this.salaryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salaryBindingNavigator.BindingSource = this.salaryBindingSource;
            this.salaryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salaryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salaryBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salaryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.salaryBindingNavigatorSaveItem});
            this.salaryBindingNavigator.Location = new System.Drawing.Point(0, 631);
            this.salaryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salaryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salaryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salaryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salaryBindingNavigator.Name = "salaryBindingNavigator";
            this.salaryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salaryBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.salaryBindingNavigator.TabIndex = 93;
            this.salaryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // salaryBindingNavigatorSaveItem
            // 
            this.salaryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salaryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salaryBindingNavigatorSaveItem.Image")));
            this.salaryBindingNavigatorSaveItem.Name = "salaryBindingNavigatorSaveItem";
            this.salaryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.salaryBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.salaryBindingNavigatorSaveItem.Click += new System.EventHandler(this.salaryBindingNavigatorSaveItem_Click);
            // 
            // премияTextBox
            // 
            this.премияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "Премия", true));
            this.премияTextBox.Location = new System.Drawing.Point(434, 277);
            this.премияTextBox.Name = "премияTextBox";
            this.премияTextBox.Size = new System.Drawing.Size(172, 20);
            this.премияTextBox.TabIndex = 94;
            // 
            // зарплатаTextBox
            // 
            this.зарплатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "Зарплата", true));
            this.зарплатаTextBox.Location = new System.Drawing.Point(434, 303);
            this.зарплатаTextBox.Name = "зарплатаTextBox";
            this.зарплатаTextBox.Size = new System.Drawing.Size(172, 20);
            this.зарплатаTextBox.TabIndex = 95;
            // 
            // итого_к_выплатеTextBox
            // 
            this.итого_к_выплатеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "Итого к выплате", true));
            this.итого_к_выплатеTextBox.Location = new System.Drawing.Point(434, 329);
            this.итого_к_выплатеTextBox.Name = "итого_к_выплатеTextBox";
            this.итого_к_выплатеTextBox.Size = new System.Drawing.Size(172, 20);
            this.итого_к_выплатеTextBox.TabIndex = 96;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::BreadFantasy.Properties.Resources.back;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = global::BreadFantasy.Properties.Resources.back;
            this.back.Location = new System.Drawing.Point(937, 584);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(35, 35);
            this.back.TabIndex = 97;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Transparent;
            this.del.FlatAppearance.BorderSize = 5;
            this.del.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del.Location = new System.Drawing.Point(498, 546);
            this.del.Margin = new System.Windows.Forms.Padding(2);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(192, 33);
            this.del.TabIndex = 133;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.BorderSize = 5;
            this.add.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(302, 546);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(192, 33);
            this.add.TabIndex = 132;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.BorderSize = 5;
            this.save.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(400, 586);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(192, 33);
            this.save.TabIndex = 131;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // lastnext
            // 
            this.lastnext.BackColor = System.Drawing.Color.Transparent;
            this.lastnext.FlatAppearance.BorderSize = 5;
            this.lastnext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.lastnext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lastnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastnext.Location = new System.Drawing.Point(596, 505);
            this.lastnext.Margin = new System.Windows.Forms.Padding(2);
            this.lastnext.Name = "lastnext";
            this.lastnext.Size = new System.Drawing.Size(94, 33);
            this.lastnext.TabIndex = 130;
            this.lastnext.Text = "Последняя";
            this.lastnext.UseVisualStyleBackColor = false;
            this.lastnext.Click += new System.EventHandler(this.lastnext_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.FlatAppearance.BorderSize = 5;
            this.next.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.Location = new System.Drawing.Point(498, 505);
            this.next.Margin = new System.Windows.Forms.Padding(2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(94, 33);
            this.next.TabIndex = 129;
            this.next.Text = "Следующая";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // last
            // 
            this.last.BackColor = System.Drawing.Color.Transparent;
            this.last.FlatAppearance.BorderSize = 5;
            this.last.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.last.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.last.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last.Location = new System.Drawing.Point(400, 505);
            this.last.Margin = new System.Windows.Forms.Padding(2);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(94, 33);
            this.last.TabIndex = 128;
            this.last.Text = "Предыдущяя";
            this.last.UseVisualStyleBackColor = false;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.Color.Transparent;
            this.first.FlatAppearance.BorderSize = 5;
            this.first.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.first.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first.Location = new System.Drawing.Point(302, 505);
            this.first.Margin = new System.Windows.Forms.Padding(2);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(94, 33);
            this.first.TabIndex = 127;
            this.first.Text = "Первая";
            this.first.UseVisualStyleBackColor = false;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // Salary_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 656);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.save);
            this.Controls.Add(this.lastnext);
            this.Controls.Add(this.next);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.back);
            this.Controls.Add(итого_к_выплатеLabel);
            this.Controls.Add(this.итого_к_выплатеTextBox);
            this.Controls.Add(зарплатаLabel);
            this.Controls.Add(this.зарплатаTextBox);
            this.Controls.Add(премияLabel);
            this.Controls.Add(this.премияTextBox);
            this.Controls.Add(this.salaryBindingNavigator);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Salary_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зарплата";
            this.Load += new System.EventHandler(this.Salary_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadFantasyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingNavigator)).EndInit();
            this.salaryBindingNavigator.ResumeLayout(false);
            this.salaryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private BreadFantasyDataSet breadFantasyDataSet;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private BreadFantasyDataSetTableAdapters.SalaryTableAdapter salaryTableAdapter;
        private BreadFantasyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator salaryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton salaryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox премияTextBox;
        private System.Windows.Forms.TextBox зарплатаTextBox;
        private System.Windows.Forms.TextBox итого_к_выплатеTextBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button lastnext;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.Button first;
    }
}