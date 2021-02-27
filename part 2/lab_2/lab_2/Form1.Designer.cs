namespace lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextTypeOfDeposit = new System.Windows.Forms.Label();
            this.TextDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TypeOfDeposit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextTypeOfDeposit
            // 
            this.TextTypeOfDeposit.AutoSize = true;
            this.TextTypeOfDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextTypeOfDeposit.Location = new System.Drawing.Point(40, 157);
            this.TextTypeOfDeposit.Name = "TextTypeOfDeposit";
            this.TextTypeOfDeposit.Size = new System.Drawing.Size(110, 20);
            this.TextTypeOfDeposit.TabIndex = 1;
            this.TextTypeOfDeposit.Text = "Тип вклада:";
            this.TextTypeOfDeposit.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextDate
            // 
            this.TextDate.AutoSize = true;
            this.TextDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextDate.Location = new System.Drawing.Point(40, 270);
            this.TextDate.Name = "TextDate";
            this.TextDate.Size = new System.Drawing.Size(143, 20);
            this.TextDate.TabIndex = 2;
            this.TextDate.Text = "Дата открытия:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(44, 303);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // TypeOfDeposit
            // 
            this.TypeOfDeposit.FormattingEnabled = true;
            this.TypeOfDeposit.Items.AddRange(new object[] {
            "\"Личный выбор\" в BYN",
            "\"Личный выбор\" в USD, EUR",
            "\"Живые деньги\" в BYN",
            "\"Живые деньги\" в USD, EUR",
            "\"Отзывный\" в BYN",
            "\"Отзывный\" в USD, EUR"});
            this.TypeOfDeposit.Location = new System.Drawing.Point(44, 194);
            this.TypeOfDeposit.Name = "TypeOfDeposit";
            this.TypeOfDeposit.Size = new System.Drawing.Size(226, 24);
            this.TypeOfDeposit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Подключение смс-оповещений:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeOfDeposit);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.TextDate);
            this.Controls.Add(this.TextTypeOfDeposit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextTypeOfDeposit;
        private System.Windows.Forms.Label TextDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox TypeOfDeposit;
        private System.Windows.Forms.Label label1;
    }
}

