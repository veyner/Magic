namespace StudentCard
{
    partial class StudentCard
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
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SaveStudentCardButton = new System.Windows.Forms.Button();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.MiddlenameLabel = new System.Windows.Forms.Label();
            this.MiddlenameTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.TelefonTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelefonNumberLabel = new System.Windows.Forms.Label();
            this.SpecialityComboBox = new System.Windows.Forms.ComboBox();
            this.CourceComboBox = new System.Windows.Forms.ComboBox();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.SpecialityLabel = new System.Windows.Forms.Label();
            this.CourceLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.FotoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(15, 22);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(169, 20);
            this.SurnameTextBox.TabIndex = 0;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // SaveStudentCardButton
            // 
            this.SaveStudentCardButton.Location = new System.Drawing.Point(91, 341);
            this.SaveStudentCardButton.Name = "SaveStudentCardButton";
            this.SaveStudentCardButton.Size = new System.Drawing.Size(145, 28);
            this.SaveStudentCardButton.TabIndex = 1;
            this.SaveStudentCardButton.Text = "Сохранить";
            this.SaveStudentCardButton.UseVisualStyleBackColor = true;
            this.SaveStudentCardButton.Click += new System.EventHandler(this.SaveStudentCardButton_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(12, 6);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(15, 71);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(169, 20);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 55);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Имя";
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(190, 167);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(121, 21);
            this.FacultyComboBox.TabIndex = 7;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(187, 154);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(63, 13);
            this.FacultyLabel.TabIndex = 8;
            this.FacultyLabel.Text = "Факультет";
            // 
            // MiddlenameLabel
            // 
            this.MiddlenameLabel.AutoSize = true;
            this.MiddlenameLabel.Location = new System.Drawing.Point(12, 104);
            this.MiddlenameLabel.Name = "MiddlenameLabel";
            this.MiddlenameLabel.Size = new System.Drawing.Size(54, 13);
            this.MiddlenameLabel.TabIndex = 9;
            this.MiddlenameLabel.Text = "Отчество";
            // 
            // MiddlenameTextBox
            // 
            this.MiddlenameTextBox.Location = new System.Drawing.Point(15, 120);
            this.MiddlenameTextBox.Name = "MiddlenameTextBox";
            this.MiddlenameTextBox.Size = new System.Drawing.Size(169, 20);
            this.MiddlenameTextBox.TabIndex = 10;
            this.MiddlenameTextBox.TextChanged += new System.EventHandler(this.MiddlenameTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(15, 170);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(169, 20);
            this.CityTextBox.TabIndex = 11;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(15, 218);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(169, 20);
            this.AddressTextBox.TabIndex = 12;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(12, 154);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(37, 13);
            this.CityLabel.TabIndex = 13;
            this.CityLabel.Text = "Город";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(12, 202);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(38, 13);
            this.AddressLabel.TabIndex = 14;
            this.AddressLabel.Text = "Адрес";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(15, 314);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(169, 20);
            this.EmailTextBox.TabIndex = 15;
            // 
            // TelefonTextBox
            // 
            this.TelefonTextBox.Location = new System.Drawing.Point(15, 266);
            this.TelefonTextBox.Name = "TelefonTextBox";
            this.TelefonTextBox.Size = new System.Drawing.Size(169, 20);
            this.TelefonTextBox.TabIndex = 16;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(14, 298);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(139, 13);
            this.EmailLabel.TabIndex = 17;
            this.EmailLabel.Text = "Адрес электронной почты";
            // 
            // TelefonNumberLabel
            // 
            this.TelefonNumberLabel.AutoSize = true;
            this.TelefonNumberLabel.Location = new System.Drawing.Point(12, 250);
            this.TelefonNumberLabel.Name = "TelefonNumberLabel";
            this.TelefonNumberLabel.Size = new System.Drawing.Size(155, 13);
            this.TelefonNumberLabel.TabIndex = 18;
            this.TelefonNumberLabel.Text = "Контактный номер телефона";
            // 
            // SpecialityComboBox
            // 
            this.SpecialityComboBox.FormattingEnabled = true;
            this.SpecialityComboBox.Location = new System.Drawing.Point(190, 215);
            this.SpecialityComboBox.Name = "SpecialityComboBox";
            this.SpecialityComboBox.Size = new System.Drawing.Size(121, 21);
            this.SpecialityComboBox.TabIndex = 19;
            this.SpecialityComboBox.SelectedIndexChanged += new System.EventHandler(this.SpecialityComboBox_SelectedIndexChanged);
            // 
            // CourceComboBox
            // 
            this.CourceComboBox.FormattingEnabled = true;
            this.CourceComboBox.Location = new System.Drawing.Point(190, 264);
            this.CourceComboBox.Name = "CourceComboBox";
            this.CourceComboBox.Size = new System.Drawing.Size(121, 21);
            this.CourceComboBox.TabIndex = 20;
            this.CourceComboBox.SelectedIndexChanged += new System.EventHandler(this.CourceComboBox_SelectedIndexChanged);
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(190, 314);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.GroupComboBox.TabIndex = 21;
            this.GroupComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox_SelectedIndexChanged);
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(187, 298);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(42, 13);
            this.GroupLabel.TabIndex = 22;
            this.GroupLabel.Text = "Группа";
            // 
            // SpecialityLabel
            // 
            this.SpecialityLabel.AutoSize = true;
            this.SpecialityLabel.Location = new System.Drawing.Point(187, 200);
            this.SpecialityLabel.Name = "SpecialityLabel";
            this.SpecialityLabel.Size = new System.Drawing.Size(85, 13);
            this.SpecialityLabel.TabIndex = 23;
            this.SpecialityLabel.Text = "Специальность";
            // 
            // CourceLabel
            // 
            this.CourceLabel.AutoSize = true;
            this.CourceLabel.Location = new System.Drawing.Point(187, 249);
            this.CourceLabel.Name = "CourceLabel";
            this.CourceLabel.Size = new System.Drawing.Size(31, 13);
            this.CourceLabel.TabIndex = 24;
            this.CourceLabel.Text = "Курс";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Location = new System.Drawing.Point(190, 12);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(121, 139);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoPictureBox.TabIndex = 27;
            this.PhotoPictureBox.TabStop = false;
            this.PhotoPictureBox.Click += new System.EventHandler(this.FotoPictureBox_Click);
            // 
            // FotoOpenFileDialog
            // 
            this.FotoOpenFileDialog.FileName = "openFileDialog1";
            // 
            // StudentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 381);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.CourceLabel);
            this.Controls.Add(this.SpecialityLabel);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.CourceComboBox);
            this.Controls.Add(this.SpecialityComboBox);
            this.Controls.Add(this.TelefonNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.TelefonTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.MiddlenameTextBox);
            this.Controls.Add(this.MiddlenameLabel);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SaveStudentCardButton);
            this.Controls.Add(this.SurnameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 420);
            this.MinimumSize = new System.Drawing.Size(342, 420);
            this.Name = "StudentCard";
            this.Text = "Карточка студента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentCard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Button SaveStudentCardButton;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Label MiddlenameLabel;
        private System.Windows.Forms.TextBox MiddlenameTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox TelefonTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TelefonNumberLabel;
        private System.Windows.Forms.ComboBox SpecialityComboBox;
        private System.Windows.Forms.ComboBox CourceComboBox;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label SpecialityLabel;
        private System.Windows.Forms.Label CourceLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.OpenFileDialog FotoOpenFileDialog;
    }
}

