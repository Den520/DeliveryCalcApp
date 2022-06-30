namespace DeliveryCalcApp
{
    partial class OrderList
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
            this.titleLable = new System.Windows.Forms.Label();
            this.pickCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.номерзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеТКDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городотправителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отдвериDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.городполучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.додвериDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.адресдоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ширинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.высотаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датадоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryOrdersDBDataSet = new DeliveryCalcApp.DeliveryOrdersDBDataSet();
            this.ordersTableTableAdapter = new DeliveryCalcApp.DeliveryOrdersDBDataSetTableAdapters.OrdersTableTableAdapter();
            this.sortButton = new System.Windows.Forms.Button();
            this.exportExcelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrdersDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLable.Location = new System.Drawing.Point(344, 9);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(195, 29);
            this.titleLable.TabIndex = 1;
            this.titleLable.Text = "Список заказов";
            // 
            // pickCompanyComboBox
            // 
            this.pickCompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickCompanyComboBox.FormattingEnabled = true;
            this.pickCompanyComboBox.Items.AddRange(new object[] {
            "Все",
            "Boxberry",
            "СДЭК",
            "Почта России"});
            this.pickCompanyComboBox.Location = new System.Drawing.Point(189, 61);
            this.pickCompanyComboBox.Name = "pickCompanyComboBox";
            this.pickCompanyComboBox.Size = new System.Drawing.Size(121, 21);
            this.pickCompanyComboBox.TabIndex = 2;
            this.pickCompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.pickCompanyComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Выберите нужную ТК:";
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзаказаDataGridViewTextBoxColumn,
            this.названиеТКDataGridViewTextBoxColumn,
            this.городотправителяDataGridViewTextBoxColumn,
            this.отдвериDataGridViewCheckBoxColumn,
            this.городполучателяDataGridViewTextBoxColumn,
            this.додвериDataGridViewCheckBoxColumn,
            this.адресдоставкиDataGridViewTextBoxColumn,
            this.длинаDataGridViewTextBoxColumn,
            this.ширинаDataGridViewTextBoxColumn,
            this.высотаDataGridViewTextBoxColumn,
            this.весDataGridViewTextBoxColumn,
            this.датазаказаDataGridViewTextBoxColumn,
            this.датадоставкиDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn});
            this.ordersDataGridView.DataSource = this.ordersTableBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 112);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.Size = new System.Drawing.Size(832, 326);
            this.ordersDataGridView.TabIndex = 19;
            // 
            // номерзаказаDataGridViewTextBoxColumn
            // 
            this.номерзаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерзаказаDataGridViewTextBoxColumn.Name = "номерзаказаDataGridViewTextBoxColumn";
            this.номерзаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеТКDataGridViewTextBoxColumn
            // 
            this.названиеТКDataGridViewTextBoxColumn.DataPropertyName = "Название_ТК";
            this.названиеТКDataGridViewTextBoxColumn.HeaderText = "Название ТК";
            this.названиеТКDataGridViewTextBoxColumn.Name = "названиеТКDataGridViewTextBoxColumn";
            this.названиеТКDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // городотправителяDataGridViewTextBoxColumn
            // 
            this.городотправителяDataGridViewTextBoxColumn.DataPropertyName = "Город_отправителя";
            this.городотправителяDataGridViewTextBoxColumn.HeaderText = "Город отправителя";
            this.городотправителяDataGridViewTextBoxColumn.Name = "городотправителяDataGridViewTextBoxColumn";
            this.городотправителяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отдвериDataGridViewCheckBoxColumn
            // 
            this.отдвериDataGridViewCheckBoxColumn.DataPropertyName = "От_двери";
            this.отдвериDataGridViewCheckBoxColumn.HeaderText = "От двери";
            this.отдвериDataGridViewCheckBoxColumn.Name = "отдвериDataGridViewCheckBoxColumn";
            this.отдвериDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // городполучателяDataGridViewTextBoxColumn
            // 
            this.городполучателяDataGridViewTextBoxColumn.DataPropertyName = "Город_получателя";
            this.городполучателяDataGridViewTextBoxColumn.HeaderText = "Город получателя";
            this.городполучателяDataGridViewTextBoxColumn.Name = "городполучателяDataGridViewTextBoxColumn";
            this.городполучателяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // додвериDataGridViewCheckBoxColumn
            // 
            this.додвериDataGridViewCheckBoxColumn.DataPropertyName = "До_двери";
            this.додвериDataGridViewCheckBoxColumn.HeaderText = "До двери";
            this.додвериDataGridViewCheckBoxColumn.Name = "додвериDataGridViewCheckBoxColumn";
            this.додвериDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // адресдоставкиDataGridViewTextBoxColumn
            // 
            this.адресдоставкиDataGridViewTextBoxColumn.DataPropertyName = "Адрес_доставки";
            this.адресдоставкиDataGridViewTextBoxColumn.HeaderText = "Адрес доставки";
            this.адресдоставкиDataGridViewTextBoxColumn.Name = "адресдоставкиDataGridViewTextBoxColumn";
            this.адресдоставкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // длинаDataGridViewTextBoxColumn
            // 
            this.длинаDataGridViewTextBoxColumn.DataPropertyName = "Длина";
            this.длинаDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.длинаDataGridViewTextBoxColumn.Name = "длинаDataGridViewTextBoxColumn";
            this.длинаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ширинаDataGridViewTextBoxColumn
            // 
            this.ширинаDataGridViewTextBoxColumn.DataPropertyName = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.HeaderText = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.Name = "ширинаDataGridViewTextBoxColumn";
            this.ширинаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // высотаDataGridViewTextBoxColumn
            // 
            this.высотаDataGridViewTextBoxColumn.DataPropertyName = "Высота";
            this.высотаDataGridViewTextBoxColumn.HeaderText = "Высота";
            this.высотаDataGridViewTextBoxColumn.Name = "высотаDataGridViewTextBoxColumn";
            this.высотаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // весDataGridViewTextBoxColumn
            // 
            this.весDataGridViewTextBoxColumn.DataPropertyName = "Вес";
            this.весDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.весDataGridViewTextBoxColumn.Name = "весDataGridViewTextBoxColumn";
            this.весDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датазаказаDataGridViewTextBoxColumn
            // 
            this.датазаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата_заказа";
            this.датазаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датазаказаDataGridViewTextBoxColumn.Name = "датазаказаDataGridViewTextBoxColumn";
            this.датазаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датадоставкиDataGridViewTextBoxColumn
            // 
            this.датадоставкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_доставки";
            this.датадоставкиDataGridViewTextBoxColumn.HeaderText = "Дата доставки";
            this.датадоставкиDataGridViewTextBoxColumn.Name = "датадоставкиDataGridViewTextBoxColumn";
            this.датадоставкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            this.номертелефонаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersTableBindingSource
            // 
            this.ordersTableBindingSource.DataMember = "OrdersTable";
            this.ordersTableBindingSource.DataSource = this.deliveryOrdersDBDataSet;
            // 
            // deliveryOrdersDBDataSet
            // 
            this.deliveryOrdersDBDataSet.DataSetName = "DeliveryOrdersDBDataSet";
            this.deliveryOrdersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableTableAdapter
            // 
            this.ordersTableTableAdapter.ClearBeforeFill = true;
            // 
            // sortButton
            // 
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortButton.Location = new System.Drawing.Point(323, 55);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(216, 31);
            this.sortButton.TabIndex = 21;
            this.sortButton.Text = "Сортировка по дате доставки";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // exportExcelButton
            // 
            this.exportExcelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportExcelButton.Location = new System.Drawing.Point(557, 55);
            this.exportExcelButton.Name = "exportExcelButton";
            this.exportExcelButton.Size = new System.Drawing.Size(216, 31);
            this.exportExcelButton.TabIndex = 42;
            this.exportExcelButton.Text = "Экспорт таблицы в Excel";
            this.exportExcelButton.UseVisualStyleBackColor = true;
            this.exportExcelButton.Click += new System.EventHandler(this.exportExcelButton_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.exportExcelButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickCompanyComboBox);
            this.Controls.Add(this.titleLable);
            this.Name = "OrderList";
            this.Text = "Список заказов";
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrdersDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.ComboBox pickCompanyComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private DeliveryOrdersDBDataSet deliveryOrdersDBDataSet;
        private System.Windows.Forms.BindingSource ordersTableBindingSource;
        private DeliveryOrdersDBDataSetTableAdapters.OrdersTableTableAdapter ordersTableTableAdapter;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеТКDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городотправителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn отдвериDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городполучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn додвериDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресдоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ширинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn высотаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датадоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exportExcelButton;
    }
}