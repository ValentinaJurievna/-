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
            this.DateTimeDeposit = new System.Windows.Forms.DateTimePicker();
            this.TypeOfDeposit = new System.Windows.Forms.ComboBox();
            this.TextAccountNumber = new System.Windows.Forms.Label();
            this.Owner = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.AgeOfOwner = new System.Windows.Forms.NumericUpDown();
            this.AgeText = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Surname_label = new System.Windows.Forms.Label();
            this.Passport_label = new System.Windows.Forms.Label();
            this.PassportOfOwner = new System.Windows.Forms.MaskedTextBox();
            this.listOfOwners = new System.Windows.Forms.ListBox();
            this.addOwner = new System.Windows.Forms.Button();
            this.deleteData = new System.Windows.Forms.Button();
            this.deleteOwners = new System.Windows.Forms.Button();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.middleName_label = new System.Windows.Forms.Label();
            this.account_label = new System.Windows.Forms.Label();
            this.Owner_label = new System.Windows.Forms.Label();
            this.label_account = new System.Windows.Forms.Label();
            this.writeToFile = new System.Windows.Forms.Button();
            this.readFromFile = new System.Windows.Forms.Button();
            this.addAccount = new System.Windows.Forms.Button();
            this.final_Information = new System.Windows.Forms.ListBox();
            this.AccountNumber = new System.Windows.Forms.MaskedTextBox();
            this.AmountOnDeposit = new System.Windows.Forms.MaskedTextBox();
            this.sms = new System.Windows.Forms.CheckBox();
            this.banking = new System.Windows.Forms.CheckBox();
            this.OwnerMakeDeposit = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.AgeOfOwner)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextTypeOfDeposit
            // 
            this.TextTypeOfDeposit.AutoSize = true;
            this.TextTypeOfDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextTypeOfDeposit.Location = new System.Drawing.Point(1000, 106);
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
            this.TextDate.Location = new System.Drawing.Point(1000, 186);
            this.TextDate.Name = "TextDate";
            this.TextDate.Size = new System.Drawing.Size(143, 20);
            this.TextDate.TabIndex = 2;
            this.TextDate.Text = "Дата открытия:";
            // 
            // DateTimeDeposit
            // 
            this.DateTimeDeposit.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.DateTimeDeposit.CalendarTrailingForeColor = System.Drawing.Color.LightBlue;
            this.DateTimeDeposit.Location = new System.Drawing.Point(1004, 217);
            this.DateTimeDeposit.Name = "DateTimeDeposit";
            this.DateTimeDeposit.Size = new System.Drawing.Size(226, 22);
            this.DateTimeDeposit.TabIndex = 3;
            // 
            // TypeOfDeposit
            // 
            this.TypeOfDeposit.BackColor = System.Drawing.Color.LightBlue;
            this.TypeOfDeposit.FormattingEnabled = true;
            this.TypeOfDeposit.Items.AddRange(new object[] {
            "\"Личный выбор\" в BYN",
            "\"Личный выбор\" в USD, EUR",
            "\"Живые деньги\" в BYN",
            "\"Живые деньги\" в USD, EUR",
            "\"Отзывный\" в BYN",
            "\"Отзывный\" в USD, EUR"});
            this.TypeOfDeposit.Location = new System.Drawing.Point(1004, 133);
            this.TypeOfDeposit.Name = "TypeOfDeposit";
            this.TypeOfDeposit.Size = new System.Drawing.Size(226, 24);
            this.TypeOfDeposit.TabIndex = 4;
            // 
            // TextAccountNumber
            // 
            this.TextAccountNumber.AutoSize = true;
            this.TextAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAccountNumber.Location = new System.Drawing.Point(744, 106);
            this.TextAccountNumber.Name = "TextAccountNumber";
            this.TextAccountNumber.Size = new System.Drawing.Size(69, 20);
            this.TextAccountNumber.TabIndex = 6;
            this.TextAccountNumber.Text = "Номер:";
            // 
            // Owner
            // 
            this.Owner.AutoSize = true;
            this.Owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Owner.Location = new System.Drawing.Point(31, 51);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(129, 29);
            this.Owner.TabIndex = 10;
            this.Owner.Text = "Владелец";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(238, 107);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(42, 20);
            this.Name_label.TabIndex = 11;
            this.Name_label.Text = "Имя";
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sex.Location = new System.Drawing.Point(32, 187);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(42, 20);
            this.Sex.TabIndex = 14;
            this.Sex.Text = "Пол";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(36, 216);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(86, 21);
            this.Male.TabIndex = 15;
            this.Male.TabStop = true;
            this.Male.Text = "Мужской";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(139, 217);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(88, 21);
            this.Female.TabIndex = 16;
            this.Female.TabStop = true;
            this.Female.Text = "Женский";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // AgeOfOwner
            // 
            this.AgeOfOwner.Location = new System.Drawing.Point(279, 216);
            this.AgeOfOwner.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.AgeOfOwner.Name = "AgeOfOwner";
            this.AgeOfOwner.Size = new System.Drawing.Size(115, 22);
            this.AgeOfOwner.TabIndex = 17;
            this.AgeOfOwner.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // AgeText
            // 
            this.AgeText.AutoSize = true;
            this.AgeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeText.Location = new System.Drawing.Point(275, 186);
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(79, 20);
            this.AgeText.TabIndex = 18;
            this.AgeText.Text = "Возраст";
            this.AgeText.Click += new System.EventHandler(this.label2_Click);
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.Color.LightBlue;
            this.Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name.Location = new System.Drawing.Point(242, 133);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(195, 22);
            this.Name.TabIndex = 19;
            // 
            // Surname
            // 
            this.Surname.BackColor = System.Drawing.Color.LightBlue;
            this.Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Surname.Location = new System.Drawing.Point(36, 133);
            this.Surname.Multiline = true;
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(195, 22);
            this.Surname.TabIndex = 21;
            // 
            // Surname_label
            // 
            this.Surname_label.AutoSize = true;
            this.Surname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_label.Location = new System.Drawing.Point(32, 107);
            this.Surname_label.Name = "Surname_label";
            this.Surname_label.Size = new System.Drawing.Size(87, 20);
            this.Surname_label.TabIndex = 20;
            this.Surname_label.Text = "Фамилия";
            // 
            // Passport_label
            // 
            this.Passport_label.AutoSize = true;
            this.Passport_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passport_label.Location = new System.Drawing.Point(32, 274);
            this.Passport_label.Name = "Passport_label";
            this.Passport_label.Size = new System.Drawing.Size(148, 20);
            this.Passport_label.TabIndex = 22;
            this.Passport_label.Text = "Номер паспорта";
            // 
            // PassportOfOwner
            // 
            this.PassportOfOwner.BackColor = System.Drawing.Color.LightBlue;
            this.PassportOfOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassportOfOwner.Location = new System.Drawing.Point(36, 304);
            this.PassportOfOwner.Mask = "LL0000000";
            this.PassportOfOwner.MaximumSize = new System.Drawing.Size(195, 36);
            this.PassportOfOwner.MinimumSize = new System.Drawing.Size(195, 36);
            this.PassportOfOwner.Name = "PassportOfOwner";
            this.PassportOfOwner.Size = new System.Drawing.Size(195, 22);
            this.PassportOfOwner.TabIndex = 23;
            // 
            // listOfOwners
            // 
            this.listOfOwners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listOfOwners.FormattingEnabled = true;
            this.listOfOwners.ItemHeight = 16;
            this.listOfOwners.Location = new System.Drawing.Point(36, 437);
            this.listOfOwners.Name = "listOfOwners";
            this.listOfOwners.Size = new System.Drawing.Size(606, 114);
            this.listOfOwners.TabIndex = 24;
            // 
            // addOwner
            // 
            this.addOwner.BackColor = System.Drawing.Color.MidnightBlue;
            this.addOwner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addOwner.ForeColor = System.Drawing.Color.White;
            this.addOwner.Location = new System.Drawing.Point(36, 369);
            this.addOwner.Name = "addOwner";
            this.addOwner.Size = new System.Drawing.Size(191, 45);
            this.addOwner.TabIndex = 25;
            this.addOwner.Text = "Добавить владельца";
            this.addOwner.UseVisualStyleBackColor = false;
            this.addOwner.Click += new System.EventHandler(this.addOwner_Click);
            // 
            // deleteData
            // 
            this.deleteData.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteData.ForeColor = System.Drawing.Color.White;
            this.deleteData.Location = new System.Drawing.Point(244, 369);
            this.deleteData.Name = "deleteData";
            this.deleteData.Size = new System.Drawing.Size(191, 45);
            this.deleteData.TabIndex = 26;
            this.deleteData.Text = "Очистить поля";
            this.deleteData.UseVisualStyleBackColor = false;
            this.deleteData.Click += new System.EventHandler(this.deleteData_Click);
            // 
            // deleteOwners
            // 
            this.deleteOwners.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteOwners.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteOwners.ForeColor = System.Drawing.Color.White;
            this.deleteOwners.Location = new System.Drawing.Point(451, 369);
            this.deleteOwners.Name = "deleteOwners";
            this.deleteOwners.Size = new System.Drawing.Size(191, 45);
            this.deleteOwners.TabIndex = 27;
            this.deleteOwners.Text = "Очистить список";
            this.deleteOwners.UseVisualStyleBackColor = false;
            this.deleteOwners.Click += new System.EventHandler(this.deleteOwners_Click);
            // 
            // MiddleName
            // 
            this.MiddleName.BackColor = System.Drawing.Color.LightBlue;
            this.MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleName.Location = new System.Drawing.Point(447, 133);
            this.MiddleName.Multiline = true;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(195, 22);
            this.MiddleName.TabIndex = 29;
            // 
            // middleName_label
            // 
            this.middleName_label.AutoSize = true;
            this.middleName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleName_label.Location = new System.Drawing.Point(443, 107);
            this.middleName_label.Name = "middleName_label";
            this.middleName_label.Size = new System.Drawing.Size(91, 20);
            this.middleName_label.TabIndex = 28;
            this.middleName_label.Text = "Отчество";
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.account_label.Location = new System.Drawing.Point(744, 190);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(70, 20);
            this.account_label.TabIndex = 31;
            this.account_label.Text = "Баланс";
            // 
            // Owner_label
            // 
            this.Owner_label.AutoSize = true;
            this.Owner_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Owner_label.Location = new System.Drawing.Point(744, 354);
            this.Owner_label.Name = "Owner_label";
            this.Owner_label.Size = new System.Drawing.Size(93, 20);
            this.Owner_label.TabIndex = 33;
            this.Owner_label.Text = "Владелец";
            // 
            // label_account
            // 
            this.label_account.AutoSize = true;
            this.label_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_account.Location = new System.Drawing.Point(743, 51);
            this.label_account.Name = "label_account";
            this.label_account.Size = new System.Drawing.Size(69, 29);
            this.label_account.TabIndex = 34;
            this.label_account.Text = "Счёт";
            // 
            // writeToFile
            // 
            this.writeToFile.BackColor = System.Drawing.Color.MidnightBlue;
            this.writeToFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.writeToFile.ForeColor = System.Drawing.Color.White;
            this.writeToFile.Location = new System.Drawing.Point(1163, 614);
            this.writeToFile.Name = "writeToFile";
            this.writeToFile.Size = new System.Drawing.Size(191, 45);
            this.writeToFile.TabIndex = 35;
            this.writeToFile.Text = "Запись в файл";
            this.writeToFile.UseVisualStyleBackColor = false;
            this.writeToFile.Click += new System.EventHandler(this.writeToFile_Click);
            // 
            // readFromFile
            // 
            this.readFromFile.BackColor = System.Drawing.Color.MidnightBlue;
            this.readFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.readFromFile.ForeColor = System.Drawing.Color.White;
            this.readFromFile.Location = new System.Drawing.Point(1163, 683);
            this.readFromFile.Name = "readFromFile";
            this.readFromFile.Size = new System.Drawing.Size(191, 45);
            this.readFromFile.TabIndex = 36;
            this.readFromFile.Text = "Чтение из файла";
            this.readFromFile.UseVisualStyleBackColor = false;
            this.readFromFile.Click += new System.EventHandler(this.readFromFile_Click);
            // 
            // addAccount
            // 
            this.addAccount.BackColor = System.Drawing.Color.MidnightBlue;
            this.addAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addAccount.ForeColor = System.Drawing.Color.White;
            this.addAccount.Location = new System.Drawing.Point(748, 506);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(191, 45);
            this.addAccount.TabIndex = 37;
            this.addAccount.Text = "Добавить счёт";
            this.addAccount.UseVisualStyleBackColor = false;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // final_Information
            // 
            this.final_Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.final_Information.FormattingEnabled = true;
            this.final_Information.HorizontalScrollbar = true;
            this.final_Information.ItemHeight = 16;
            this.final_Information.Location = new System.Drawing.Point(36, 614);
            this.final_Information.Name = "final_Information";
            this.final_Information.Size = new System.Drawing.Size(1107, 114);
            this.final_Information.TabIndex = 38;
            // 
            // AccountNumber
            // 
            this.AccountNumber.BackColor = System.Drawing.Color.LightBlue;
            this.AccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountNumber.Location = new System.Drawing.Point(748, 134);
            this.AccountNumber.Mask = "0000-0000-0000-0000";
            this.AccountNumber.MaximumSize = new System.Drawing.Size(195, 36);
            this.AccountNumber.MinimumSize = new System.Drawing.Size(195, 36);
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Size = new System.Drawing.Size(195, 22);
            this.AccountNumber.TabIndex = 39;
            // 
            // AmountOnDeposit
            // 
            this.AmountOnDeposit.BackColor = System.Drawing.Color.LightBlue;
            this.AmountOnDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountOnDeposit.Location = new System.Drawing.Point(748, 217);
            this.AmountOnDeposit.Mask = "0000$:";
            this.AmountOnDeposit.MaximumSize = new System.Drawing.Size(195, 36);
            this.AmountOnDeposit.MinimumSize = new System.Drawing.Size(195, 36);
            this.AmountOnDeposit.Name = "AmountOnDeposit";
            this.AmountOnDeposit.Size = new System.Drawing.Size(195, 22);
            this.AmountOnDeposit.TabIndex = 40;
            // 
            // sms
            // 
            this.sms.AutoSize = true;
            this.sms.Location = new System.Drawing.Point(748, 286);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(235, 21);
            this.sms.TabIndex = 41;
            this.sms.Text = "Подключение смс-оповещений";
            this.sms.UseVisualStyleBackColor = true;
            // 
            // banking
            // 
            this.banking.AutoSize = true;
            this.banking.Location = new System.Drawing.Point(1004, 286);
            this.banking.Name = "banking";
            this.banking.Size = new System.Drawing.Size(251, 21);
            this.banking.TabIndex = 42;
            this.banking.Text = "Подключение интернет банкинга";
            this.banking.UseVisualStyleBackColor = true;
            // 
            // OwnerMakeDeposit
            // 
            this.OwnerMakeDeposit.FormattingEnabled = true;
            this.OwnerMakeDeposit.Location = new System.Drawing.Point(748, 389);
            this.OwnerMakeDeposit.Name = "OwnerMakeDeposit";
            this.OwnerMakeDeposit.Size = new System.Drawing.Size(482, 89);
            this.OwnerMakeDeposit.TabIndex = 43;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search,
            this.Sort,
            this.Save,
            this.aboutProgram});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1415, 30);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Search
            // 
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(67, 26);
            this.Search.Text = "Поиск";
            // 
            // Sort
            // 
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(109, 26);
            this.Sort.Text = "Сортировка";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 26);
            this.Save.Text = "Сохранить";
            // 
            // aboutProgram
            // 
            this.aboutProgram.Name = "aboutProgram";
            this.aboutProgram.Size = new System.Drawing.Size(120, 26);
            this.aboutProgram.Text = "О программе";
            this.aboutProgram.Click += new System.EventHandler(this.aboutProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 758);
            this.Controls.Add(this.OwnerMakeDeposit);
            this.Controls.Add(this.banking);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.AmountOnDeposit);
            this.Controls.Add(this.AccountNumber);
            this.Controls.Add(this.final_Information);
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.readFromFile);
            this.Controls.Add(this.writeToFile);
            this.Controls.Add(this.label_account);
            this.Controls.Add(this.Owner_label);
            this.Controls.Add(this.account_label);
            this.Controls.Add(this.Owner);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.middleName_label);
            this.Controls.Add(this.deleteOwners);
            this.Controls.Add(this.deleteData);
            this.Controls.Add(this.addOwner);
            this.Controls.Add(this.listOfOwners);
            this.Controls.Add(this.PassportOfOwner);
            this.Controls.Add(this.Passport_label);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Surname_label);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.AgeText);
            this.Controls.Add(this.AgeOfOwner);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.TextAccountNumber);
            this.Controls.Add(this.TypeOfDeposit);
            this.Controls.Add(this.DateTimeDeposit);
            this.Controls.Add(this.TextDate);
            this.Controls.Add(this.TextTypeOfDeposit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
    
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AgeOfOwner)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextTypeOfDeposit;
        private System.Windows.Forms.Label TextDate;
        private System.Windows.Forms.DateTimePicker DateTimeDeposit;
        private System.Windows.Forms.ComboBox TypeOfDeposit;
        private System.Windows.Forms.Label TextAccountNumber;
        private System.Windows.Forms.Label Owner;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.NumericUpDown AgeOfOwner;
        private System.Windows.Forms.Label AgeText;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label Surname_label;
        private System.Windows.Forms.Label Passport_label;
        private System.Windows.Forms.MaskedTextBox PassportOfOwner;
        private System.Windows.Forms.ListBox listOfOwners;
        private System.Windows.Forms.Button addOwner;
        private System.Windows.Forms.Button deleteData;
        private System.Windows.Forms.Button deleteOwners;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Label middleName_label;
        private System.Windows.Forms.Label account_label;
        private System.Windows.Forms.Label Owner_label;
        private System.Windows.Forms.Label label_account;
        private System.Windows.Forms.Button writeToFile;
        private System.Windows.Forms.Button readFromFile;
        private System.Windows.Forms.Button addAccount;
        private System.Windows.Forms.ListBox final_Information;
        private System.Windows.Forms.MaskedTextBox AccountNumber;
        private System.Windows.Forms.MaskedTextBox AmountOnDeposit;
        private System.Windows.Forms.CheckBox sms;
        private System.Windows.Forms.CheckBox banking;
        private System.Windows.Forms.CheckedListBox OwnerMakeDeposit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripMenuItem Sort;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem aboutProgram;
    }
}

