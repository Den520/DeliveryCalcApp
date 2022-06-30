namespace DeliveryCalcApp
{
    partial class CalculationForm
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
            this.titleLable = new System.Windows.Forms.Label();
            this.sendingPointComboBox = new System.Windows.Forms.ComboBox();
            this.destinationPointComboBox = new System.Windows.Forms.ComboBox();
            this.sendingPointLabel = new System.Windows.Forms.Label();
            this.destinationPointLabel = new System.Windows.Forms.Label();
            this.fromDoorCheckBox = new System.Windows.Forms.CheckBox();
            this.toDoorCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destinationAddressTextBox = new System.Windows.Forms.TextBox();
            this.destinationAddressLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceBoxberryLabel = new System.Windows.Forms.Label();
            this.dateBoxberryLabel = new System.Windows.Forms.Label();
            this.priceCDEKLabel = new System.Windows.Forms.Label();
            this.dateCDEKLabel = new System.Windows.Forms.Label();
            this.priceRussianPostLabel = new System.Windows.Forms.Label();
            this.dateRussianPostLabel = new System.Windows.Forms.Label();
            this.boxberryRadioButton = new System.Windows.Forms.RadioButton();
            this.CDEKRadioButton = new System.Windows.Forms.RadioButton();
            this.russianPostRadioButton = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.orderRegistrationButton = new System.Windows.Forms.Button();
            this.orderListButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLable.Location = new System.Drawing.Point(283, 9);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(205, 29);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Расчёт доставки";
            // 
            // sendingPointComboBox
            // 
            this.sendingPointComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sendingPointComboBox.FormattingEnabled = true;
            this.sendingPointComboBox.Items.AddRange(new object[] {
            "Санкт-Петербург",
            "Москва",
            "Ульяновск",
            "Омск",
            "Новосибирск",
            "Иркутск",
            "Владивосток"});
            this.sendingPointComboBox.Location = new System.Drawing.Point(116, 92);
            this.sendingPointComboBox.Name = "sendingPointComboBox";
            this.sendingPointComboBox.Size = new System.Drawing.Size(121, 21);
            this.sendingPointComboBox.TabIndex = 1;
            // 
            // destinationPointComboBox
            // 
            this.destinationPointComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationPointComboBox.FormattingEnabled = true;
            this.destinationPointComboBox.Items.AddRange(new object[] {
            "Санкт-Петербург",
            "Москва",
            "Ульяновск",
            "Омск",
            "Новосибирск",
            "Иркутск",
            "Владивосток"});
            this.destinationPointComboBox.Location = new System.Drawing.Point(540, 92);
            this.destinationPointComboBox.Name = "destinationPointComboBox";
            this.destinationPointComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinationPointComboBox.TabIndex = 2;
            // 
            // sendingPointLabel
            // 
            this.sendingPointLabel.AutoSize = true;
            this.sendingPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendingPointLabel.Location = new System.Drawing.Point(141, 58);
            this.sendingPointLabel.Name = "sendingPointLabel";
            this.sendingPointLabel.Size = new System.Drawing.Size(65, 20);
            this.sendingPointLabel.TabIndex = 3;
            this.sendingPointLabel.Text = "Откуда";
            // 
            // destinationPointLabel
            // 
            this.destinationPointLabel.AutoSize = true;
            this.destinationPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.destinationPointLabel.Location = new System.Drawing.Point(579, 58);
            this.destinationPointLabel.Name = "destinationPointLabel";
            this.destinationPointLabel.Size = new System.Drawing.Size(46, 20);
            this.destinationPointLabel.TabIndex = 4;
            this.destinationPointLabel.Text = "Куда";
            // 
            // fromDoorCheckBox
            // 
            this.fromDoorCheckBox.AutoSize = true;
            this.fromDoorCheckBox.Location = new System.Drawing.Point(134, 132);
            this.fromDoorCheckBox.Name = "fromDoorCheckBox";
            this.fromDoorCheckBox.Size = new System.Drawing.Size(72, 17);
            this.fromDoorCheckBox.TabIndex = 5;
            this.fromDoorCheckBox.Text = "От двери";
            this.fromDoorCheckBox.UseVisualStyleBackColor = true;
            // 
            // toDoorCheckBox
            // 
            this.toDoorCheckBox.AutoSize = true;
            this.toDoorCheckBox.Location = new System.Drawing.Point(562, 132);
            this.toDoorCheckBox.Name = "toDoorCheckBox";
            this.toDoorCheckBox.Size = new System.Drawing.Size(74, 17);
            this.toDoorCheckBox.TabIndex = 6;
            this.toDoorCheckBox.Text = "До двери";
            this.toDoorCheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(175, 279);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 7;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(281, 279);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 8;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(387, 279);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 9;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(493, 279);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 10;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthLabel.Location = new System.Drawing.Point(184, 256);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(91, 20);
            this.lengthLabel.TabIndex = 11;
            this.lengthLabel.Text = "Длина (см)";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLabel.Location = new System.Drawing.Point(281, 256);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(100, 20);
            this.widthLabel.TabIndex = 12;
            this.widthLabel.Text = "Ширина (см)";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(388, 256);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(99, 20);
            this.heightLabel.TabIndex = 13;
            this.heightLabel.Text = "Высота (см)";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightLabel.Location = new System.Drawing.Point(507, 256);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(66, 20);
            this.weightLabel.TabIndex = 14;
            this.weightLabel.Text = "Вес (кг)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Габариты и вес";
            // 
            // destinationAddressTextBox
            // 
            this.destinationAddressTextBox.Location = new System.Drawing.Point(325, 176);
            this.destinationAddressTextBox.Name = "destinationAddressTextBox";
            this.destinationAddressTextBox.Size = new System.Drawing.Size(236, 20);
            this.destinationAddressTextBox.TabIndex = 16;
            // 
            // destinationAddressLabel
            // 
            this.destinationAddressLabel.AutoSize = true;
            this.destinationAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.destinationAddressLabel.Location = new System.Drawing.Point(168, 174);
            this.destinationAddressLabel.Name = "destinationAddressLabel";
            this.destinationAddressLabel.Size = new System.Drawing.Size(151, 20);
            this.destinationAddressLabel.TabIndex = 17;
            this.destinationAddressLabel.Text = "Адрес получателя";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(193, 314);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(350, 33);
            this.calculateButton.TabIndex = 20;
            this.calculateButton.Text = "Рассчитать стоимость и сроки доставки";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Дата доставки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Стоимость (руб)";
            // 
            // priceBoxberryLabel
            // 
            this.priceBoxberryLabel.AutoSize = true;
            this.priceBoxberryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceBoxberryLabel.Location = new System.Drawing.Point(213, 464);
            this.priceBoxberryLabel.Name = "priceBoxberryLabel";
            this.priceBoxberryLabel.Size = new System.Drawing.Size(54, 20);
            this.priceBoxberryLabel.TabIndex = 24;
            this.priceBoxberryLabel.Text = "Пусто";
            // 
            // dateBoxberryLabel
            // 
            this.dateBoxberryLabel.AutoSize = true;
            this.dateBoxberryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBoxberryLabel.Location = new System.Drawing.Point(213, 418);
            this.dateBoxberryLabel.Name = "dateBoxberryLabel";
            this.dateBoxberryLabel.Size = new System.Drawing.Size(54, 20);
            this.dateBoxberryLabel.TabIndex = 23;
            this.dateBoxberryLabel.Text = "Пусто";
            // 
            // priceCDEKLabel
            // 
            this.priceCDEKLabel.AutoSize = true;
            this.priceCDEKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCDEKLabel.Location = new System.Drawing.Point(398, 464);
            this.priceCDEKLabel.Name = "priceCDEKLabel";
            this.priceCDEKLabel.Size = new System.Drawing.Size(54, 20);
            this.priceCDEKLabel.TabIndex = 27;
            this.priceCDEKLabel.Text = "Пусто";
            // 
            // dateCDEKLabel
            // 
            this.dateCDEKLabel.AutoSize = true;
            this.dateCDEKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCDEKLabel.Location = new System.Drawing.Point(398, 418);
            this.dateCDEKLabel.Name = "dateCDEKLabel";
            this.dateCDEKLabel.Size = new System.Drawing.Size(54, 20);
            this.dateCDEKLabel.TabIndex = 26;
            this.dateCDEKLabel.Text = "Пусто";
            // 
            // priceRussianPostLabel
            // 
            this.priceRussianPostLabel.AutoSize = true;
            this.priceRussianPostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceRussianPostLabel.Location = new System.Drawing.Point(587, 464);
            this.priceRussianPostLabel.Name = "priceRussianPostLabel";
            this.priceRussianPostLabel.Size = new System.Drawing.Size(54, 20);
            this.priceRussianPostLabel.TabIndex = 30;
            this.priceRussianPostLabel.Text = "Пусто";
            // 
            // dateRussianPostLabel
            // 
            this.dateRussianPostLabel.AutoSize = true;
            this.dateRussianPostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateRussianPostLabel.Location = new System.Drawing.Point(587, 418);
            this.dateRussianPostLabel.Name = "dateRussianPostLabel";
            this.dateRussianPostLabel.Size = new System.Drawing.Size(54, 20);
            this.dateRussianPostLabel.TabIndex = 29;
            this.dateRussianPostLabel.Text = "Пусто";
            // 
            // boxberryRadioButton
            // 
            this.boxberryRadioButton.AutoSize = true;
            this.boxberryRadioButton.Enabled = false;
            this.boxberryRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxberryRadioButton.Location = new System.Drawing.Point(208, 377);
            this.boxberryRadioButton.Name = "boxberryRadioButton";
            this.boxberryRadioButton.Size = new System.Drawing.Size(89, 24);
            this.boxberryRadioButton.TabIndex = 34;
            this.boxberryRadioButton.TabStop = true;
            this.boxberryRadioButton.Text = "Boxberry";
            this.boxberryRadioButton.UseVisualStyleBackColor = true;
            // 
            // CDEKRadioButton
            // 
            this.CDEKRadioButton.AutoSize = true;
            this.CDEKRadioButton.Enabled = false;
            this.CDEKRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CDEKRadioButton.Location = new System.Drawing.Point(397, 377);
            this.CDEKRadioButton.Name = "CDEKRadioButton";
            this.CDEKRadioButton.Size = new System.Drawing.Size(72, 24);
            this.CDEKRadioButton.TabIndex = 35;
            this.CDEKRadioButton.TabStop = true;
            this.CDEKRadioButton.Text = "СДЭК";
            this.CDEKRadioButton.UseVisualStyleBackColor = true;
            // 
            // russianPostRadioButton
            // 
            this.russianPostRadioButton.AutoSize = true;
            this.russianPostRadioButton.Enabled = false;
            this.russianPostRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.russianPostRadioButton.Location = new System.Drawing.Point(567, 377);
            this.russianPostRadioButton.Name = "russianPostRadioButton";
            this.russianPostRadioButton.Size = new System.Drawing.Size(132, 24);
            this.russianPostRadioButton.TabIndex = 36;
            this.russianPostRadioButton.TabStop = true;
            this.russianPostRadioButton.Text = "Почта России";
            this.russianPostRadioButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(21, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "Выбор доступных ТК";
            // 
            // orderRegistrationButton
            // 
            this.orderRegistrationButton.Enabled = false;
            this.orderRegistrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderRegistrationButton.Location = new System.Drawing.Point(261, 533);
            this.orderRegistrationButton.Name = "orderRegistrationButton";
            this.orderRegistrationButton.Size = new System.Drawing.Size(227, 32);
            this.orderRegistrationButton.TabIndex = 38;
            this.orderRegistrationButton.Text = "Перейти к оформлению";
            this.orderRegistrationButton.UseVisualStyleBackColor = true;
            this.orderRegistrationButton.Click += new System.EventHandler(this.orderRegistrationButton_Click);
            // 
            // orderListButton
            // 
            this.orderListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderListButton.Location = new System.Drawing.Point(12, 12);
            this.orderListButton.Name = "orderListButton";
            this.orderListButton.Size = new System.Drawing.Size(227, 32);
            this.orderListButton.TabIndex = 39;
            this.orderListButton.Text = "Открыть список заказов";
            this.orderListButton.UseVisualStyleBackColor = true;
            this.orderListButton.Click += new System.EventHandler(this.orderListButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(21, 501);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(700, 20);
            this.warningLabel.TabIndex = 40;
            this.warningLabel.Text = "Некоторые ТК могут быть недоступны для выбора из-за ограничений по габаритам и ве" +
    "су.";
            this.warningLabel.Visible = false;
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 609);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.orderListButton);
            this.Controls.Add(this.orderRegistrationButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.russianPostRadioButton);
            this.Controls.Add(this.CDEKRadioButton);
            this.Controls.Add(this.boxberryRadioButton);
            this.Controls.Add(this.priceRussianPostLabel);
            this.Controls.Add(this.dateRussianPostLabel);
            this.Controls.Add(this.priceCDEKLabel);
            this.Controls.Add(this.dateCDEKLabel);
            this.Controls.Add(this.priceBoxberryLabel);
            this.Controls.Add(this.dateBoxberryLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.destinationAddressLabel);
            this.Controls.Add(this.destinationAddressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.toDoorCheckBox);
            this.Controls.Add(this.fromDoorCheckBox);
            this.Controls.Add(this.destinationPointLabel);
            this.Controls.Add(this.sendingPointLabel);
            this.Controls.Add(this.destinationPointComboBox);
            this.Controls.Add(this.sendingPointComboBox);
            this.Controls.Add(this.titleLable);
            this.Name = "CalculationForm";
            this.Text = "Расчёт доставки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.ComboBox sendingPointComboBox;
        private System.Windows.Forms.ComboBox destinationPointComboBox;
        private System.Windows.Forms.Label sendingPointLabel;
        private System.Windows.Forms.Label destinationPointLabel;
        private System.Windows.Forms.CheckBox fromDoorCheckBox;
        private System.Windows.Forms.CheckBox toDoorCheckBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destinationAddressTextBox;
        private System.Windows.Forms.Label destinationAddressLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label priceBoxberryLabel;
        private System.Windows.Forms.Label dateBoxberryLabel;
        private System.Windows.Forms.Label priceCDEKLabel;
        private System.Windows.Forms.Label dateCDEKLabel;
        private System.Windows.Forms.Label priceRussianPostLabel;
        private System.Windows.Forms.Label dateRussianPostLabel;
        private System.Windows.Forms.RadioButton boxberryRadioButton;
        private System.Windows.Forms.RadioButton CDEKRadioButton;
        private System.Windows.Forms.RadioButton russianPostRadioButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button orderRegistrationButton;
        private System.Windows.Forms.Button orderListButton;
        private System.Windows.Forms.Label warningLabel;
    }
}