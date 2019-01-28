namespace StudentCard
{
    partial class StudentTable
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
            this.StudentListDataGridView = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourceLabel = new System.Windows.Forms.Label();
            this.SpecialityLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.CourceComboBox = new System.Windows.Forms.ComboBox();
            this.SpecialityComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.LoadNewStudentCardButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentListDataGridView
            // 
            this.StudentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Names,
            this.MiddleName,
            this.City,
            this.Street,
            this.TelefonNumber,
            this.Email,
            this.Faculty,
            this.Speciality,
            this.Group,
            this.Cource});
            this.StudentListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.StudentListDataGridView.Name = "StudentListDataGridView";
            this.StudentListDataGridView.ReadOnly = true;
            this.StudentListDataGridView.Size = new System.Drawing.Size(1160, 420);
            this.StudentListDataGridView.TabIndex = 0;
            this.StudentListDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentListDataGridView_CellMouseDoubleClick);
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Names
            // 
            this.Names.DataPropertyName = "Names";
            this.Names.HeaderText = "Имя";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MiddleName";
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Город";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Street
            // 
            this.Street.DataPropertyName = "Street";
            this.Street.HeaderText = "Улица";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            // 
            // TelefonNumber
            // 
            this.TelefonNumber.DataPropertyName = "TelefonNumber";
            this.TelefonNumber.HeaderText = "Телефон";
            this.TelefonNumber.Name = "TelefonNumber";
            this.TelefonNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Faculty
            // 
            this.Faculty.DataPropertyName = "FacultyName";
            this.Faculty.HeaderText = "Факультет";
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            // 
            // Speciality
            // 
            this.Speciality.DataPropertyName = "SpecialityName";
            this.Speciality.HeaderText = "Специальность";
            this.Speciality.Name = "Speciality";
            this.Speciality.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "GroupName";
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Cource
            // 
            this.Cource.DataPropertyName = "Cource";
            this.Cource.HeaderText = "Курс";
            this.Cource.Name = "Cource";
            this.Cource.ReadOnly = true;
            // 
            // CourceLabel
            // 
            this.CourceLabel.AutoSize = true;
            this.CourceLabel.Location = new System.Drawing.Point(266, 436);
            this.CourceLabel.Name = "CourceLabel";
            this.CourceLabel.Size = new System.Drawing.Size(31, 13);
            this.CourceLabel.TabIndex = 32;
            this.CourceLabel.Text = "Курс";
            // 
            // SpecialityLabel
            // 
            this.SpecialityLabel.AutoSize = true;
            this.SpecialityLabel.Location = new System.Drawing.Point(139, 436);
            this.SpecialityLabel.Name = "SpecialityLabel";
            this.SpecialityLabel.Size = new System.Drawing.Size(85, 13);
            this.SpecialityLabel.TabIndex = 31;
            this.SpecialityLabel.Text = "Специальность";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(393, 435);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(42, 13);
            this.GroupLabel.TabIndex = 30;
            this.GroupLabel.Text = "Группа";
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(396, 451);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.GroupComboBox.TabIndex = 29;
            this.GroupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // CourceComboBox
            // 
            this.CourceComboBox.FormattingEnabled = true;
            this.CourceComboBox.Location = new System.Drawing.Point(269, 451);
            this.CourceComboBox.Name = "CourceComboBox";
            this.CourceComboBox.Size = new System.Drawing.Size(121, 21);
            this.CourceComboBox.TabIndex = 28;
            this.CourceComboBox.SelectedIndexChanged += new System.EventHandler(this.courceComboBox_SelectedIndexChanged);
            // 
            // SpecialityComboBox
            // 
            this.SpecialityComboBox.FormattingEnabled = true;
            this.SpecialityComboBox.Location = new System.Drawing.Point(142, 451);
            this.SpecialityComboBox.Name = "SpecialityComboBox";
            this.SpecialityComboBox.Size = new System.Drawing.Size(121, 21);
            this.SpecialityComboBox.TabIndex = 27;
            this.SpecialityComboBox.SelectedIndexChanged += new System.EventHandler(this.specialityComboBox_SelectedIndexChanged);
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(12, 438);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(63, 13);
            this.FacultyLabel.TabIndex = 26;
            this.FacultyLabel.Text = "Факультет";
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(15, 451);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(121, 21);
            this.FacultyComboBox.TabIndex = 25;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.facultyComboBox_SelectedIndexChanged);
            // 
            // LoadNewStudentCardButton
            // 
            this.LoadNewStudentCardButton.Location = new System.Drawing.Point(565, 451);
            this.LoadNewStudentCardButton.Name = "LoadNewStudentCardButton";
            this.LoadNewStudentCardButton.Size = new System.Drawing.Size(243, 23);
            this.LoadNewStudentCardButton.TabIndex = 33;
            this.LoadNewStudentCardButton.Text = "Новая карточка студента";
            this.LoadNewStudentCardButton.UseVisualStyleBackColor = true;
            this.LoadNewStudentCardButton.Click += new System.EventHandler(this.LoadNewStudentCardButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(850, 451);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(190, 20);
            this.DeleteButton.TabIndex = 34;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StudentTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 485);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LoadNewStudentCardButton);
            this.Controls.Add(this.CourceLabel);
            this.Controls.Add(this.SpecialityLabel);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.CourceComboBox);
            this.Controls.Add(this.SpecialityComboBox);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.StudentListDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentTable";
            this.Text = "Список студентов";
            this.Load += new System.EventHandler(this.StudentTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentListDataGridView;
        private System.Windows.Forms.Label CourceLabel;
        private System.Windows.Forms.Label SpecialityLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.ComboBox CourceComboBox;
        private System.Windows.Forms.ComboBox SpecialityComboBox;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cource;
        private System.Windows.Forms.Button LoadNewStudentCardButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}