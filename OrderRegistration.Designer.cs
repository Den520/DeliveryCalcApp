namespace DeliveryCalcApp
{
    partial class OrderRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.patronymicMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.acceptOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление заказа";
            // 
            // lastNameMaskedTextBox
            // 
            this.lastNameMaskedTextBox.HidePromptOnLeave = true;
            this.lastNameMaskedTextBox.Location = new System.Drawing.Point(38, 112);
            this.lastNameMaskedTextBox.Mask = "LL??????????????";
            this.lastNameMaskedTextBox.Name = "lastNameMaskedTextBox";
            this.lastNameMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameMaskedTextBox.TabIndex = 1;
            // 
            // nameMaskedTextBox
            // 
            this.nameMaskedTextBox.HidePromptOnLeave = true;
            this.nameMaskedTextBox.Location = new System.Drawing.Point(206, 112);
            this.nameMaskedTextBox.Mask = "LL??????????????";
            this.nameMaskedTextBox.Name = "nameMaskedTextBox";
            this.nameMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameMaskedTextBox.TabIndex = 2;
            // 
            // patronymicMaskedTextBox
            // 
            this.patronymicMaskedTextBox.HidePromptOnLeave = true;
            this.patronymicMaskedTextBox.Location = new System.Drawing.Point(387, 112);
            this.patronymicMaskedTextBox.Mask = "????????????????";
            this.patronymicMaskedTextBox.Name = "patronymicMaskedTextBox";
            this.patronymicMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronymicMaskedTextBox.TabIndex = 3;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.HidePromptOnLeave = true;
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(570, 112);
            this.phoneMaskedTextBox.Mask = "+7 (000) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneMaskedTextBox.TabIndex = 4;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightLabel.Location = new System.Drawing.Point(550, 73);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(142, 20);
            this.weightLabel.TabIndex = 18;
            this.weightLabel.Text = "Номер телефона";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(342, 73);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(192, 20);
            this.heightLabel.TabIndex = 17;
            this.heightLabel.Text = "Отчество (при наличии)";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLabel.Location = new System.Drawing.Point(230, 73);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(40, 20);
            this.widthLabel.TabIndex = 16;
            this.widthLabel.Text = "Имя";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthLabel.Location = new System.Drawing.Point(48, 73);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(81, 20);
            this.lengthLabel.TabIndex = 15;
            this.lengthLabel.Text = "Фамилия";
            // 
            // acceptOrderButton
            // 
            this.acceptOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptOrderButton.Location = new System.Drawing.Point(234, 171);
            this.acceptOrderButton.Name = "acceptOrderButton";
            this.acceptOrderButton.Size = new System.Drawing.Size(274, 32);
            this.acceptOrderButton.TabIndex = 39;
            this.acceptOrderButton.Text = "Подтвердить и оформить заказ";
            this.acceptOrderButton.UseVisualStyleBackColor = true;
            this.acceptOrderButton.Click += new System.EventHandler(this.acceptOrderButton_Click);
            // 
            // OrderRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 269);
            this.Controls.Add(this.acceptOrderButton);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.patronymicMaskedTextBox);
            this.Controls.Add(this.nameMaskedTextBox);
            this.Controls.Add(this.lastNameMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Name = "OrderRegistration";
            this.Text = "Оформление заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox lastNameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox nameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox patronymicMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Button acceptOrderButton;
    }
}