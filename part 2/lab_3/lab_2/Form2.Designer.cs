namespace lab_2
{
    partial class Form2
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
            this.Title = new System.Windows.Forms.Label();
            this.number_text = new System.Windows.Forms.Label();
            this.surname_text = new System.Windows.Forms.Label();
            this.account_text = new System.Windows.Forms.Label();
            this.type_text = new System.Windows.Forms.Label();
            this.Number_search = new System.Windows.Forms.MaskedTextBox();
            this.Surname_search = new System.Windows.Forms.TextBox();
            this.Account_search = new System.Windows.Forms.MaskedTextBox();
            this.TypeOfDeposit_search = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(88, 49);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(346, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Введите данные для поиска";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number_text
            // 
            this.number_text.AutoSize = true;
            this.number_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_text.Location = new System.Drawing.Point(57, 143);
            this.number_text.Name = "number_text";
            this.number_text.Size = new System.Drawing.Size(118, 20);
            this.number_text.TabIndex = 1;
            this.number_text.Text = "Номер счёта";
            // 
            // surname_text
            // 
            this.surname_text.AutoSize = true;
            this.surname_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_text.Location = new System.Drawing.Point(57, 201);
            this.surname_text.Name = "surname_text";
            this.surname_text.Size = new System.Drawing.Size(87, 20);
            this.surname_text.TabIndex = 2;
            this.surname_text.Text = "Фамилия";
            // 
            // account_text
            // 
            this.account_text.AutoSize = true;
            this.account_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.account_text.Location = new System.Drawing.Point(57, 255);
            this.account_text.Name = "account_text";
            this.account_text.Size = new System.Drawing.Size(70, 20);
            this.account_text.TabIndex = 3;
            this.account_text.Text = "Баланс";
            // 
            // type_text
            // 
            this.type_text.AutoSize = true;
            this.type_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_text.Location = new System.Drawing.Point(57, 305);
            this.type_text.Name = "type_text";
            this.type_text.Size = new System.Drawing.Size(105, 20);
            this.type_text.TabIndex = 4;
            this.type_text.Text = "Тип вклада";
            // 
            // Number_search
            // 
            this.Number_search.BackColor = System.Drawing.Color.LightBlue;
            this.Number_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number_search.Location = new System.Drawing.Point(198, 141);
            this.Number_search.Mask = "0000-0000-0000-0000";
            this.Number_search.Name = "Number_search";
            this.Number_search.Size = new System.Drawing.Size(265, 22);
            this.Number_search.TabIndex = 5;
            // 
            // Surname_search
            // 
            this.Surname_search.BackColor = System.Drawing.Color.LightBlue;
            this.Surname_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Surname_search.Location = new System.Drawing.Point(198, 199);
            this.Surname_search.Name = "Surname_search";
            this.Surname_search.Size = new System.Drawing.Size(265, 22);
            this.Surname_search.TabIndex = 6;
            // 
            // Account_search
            // 
            this.Account_search.BackColor = System.Drawing.Color.LightBlue;
            this.Account_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Account_search.Location = new System.Drawing.Point(198, 253);
            this.Account_search.Mask = "0000$";
            this.Account_search.Name = "Account_search";
            this.Account_search.Size = new System.Drawing.Size(265, 22);
            this.Account_search.TabIndex = 7;
            // 
            // TypeOfDeposit_search
            // 
            this.TypeOfDeposit_search.BackColor = System.Drawing.Color.LightBlue;
            this.TypeOfDeposit_search.FormattingEnabled = true;
            this.TypeOfDeposit_search.Items.AddRange(new object[] {
            "\"Личный выбор\" в BYN",
            "\"Личный выбор\" в USD, EUR",
            "\"Живые деньги\" в BYN",
            "\"Живые деньги\" в USD, EUR",
            "\"Отзывный\" в BYN",
            "\"Отзывный\" в USD, EUR"});
            this.TypeOfDeposit_search.Location = new System.Drawing.Point(198, 303);
            this.TypeOfDeposit_search.Name = "TypeOfDeposit_search";
            this.TypeOfDeposit_search.Size = new System.Drawing.Size(265, 24);
            this.TypeOfDeposit_search.TabIndex = 8;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(61, 373);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(191, 45);
            this.button_search.TabIndex = 26;
            this.button_search.Text = "Найти";
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(272, 373);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(191, 45);
            this.button_delete.TabIndex = 27;
            this.button_delete.Text = "Очистить поля";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.TypeOfDeposit_search);
            this.Controls.Add(this.Account_search);
            this.Controls.Add(this.Surname_search);
            this.Controls.Add(this.Number_search);
            this.Controls.Add(this.type_text);
            this.Controls.Add(this.account_text);
            this.Controls.Add(this.surname_text);
            this.Controls.Add(this.number_text);
            this.Controls.Add(this.Title);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label number_text;
        private System.Windows.Forms.Label surname_text;
        private System.Windows.Forms.Label account_text;
        private System.Windows.Forms.Label type_text;
        private System.Windows.Forms.MaskedTextBox Number_search;
        private System.Windows.Forms.TextBox Surname_search;
        private System.Windows.Forms.MaskedTextBox Account_search;
        private System.Windows.Forms.ComboBox TypeOfDeposit_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
    }
}