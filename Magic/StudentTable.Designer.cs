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
            this.StudentCardsTreeView = new System.Windows.Forms.TreeView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SurnameSearchTextBox = new System.Windows.Forms.TextBox();
            this.NameSearchTextBox = new System.Windows.Forms.TextBox();
            this.MidNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SurnameSearchLabel = new System.Windows.Forms.Label();
            this.NameSearchLabel = new System.Windows.Forms.Label();
            this.MidNameSearchLabel = new System.Windows.Forms.Label();
            this.DeleteSearchButton = new System.Windows.Forms.Button();
            this.CourceLabel = new System.Windows.Forms.Label();
            this.CourceSearchComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.TelefonNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelefonTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.MiddlenameTextBox = new System.Windows.Forms.TextBox();
            this.MiddlenameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeInfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentCardsTreeView
            // 
            this.StudentCardsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentCardsTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentCardsTreeView.Location = new System.Drawing.Point(305, 8);
            this.StudentCardsTreeView.Name = "StudentCardsTreeView";
            this.StudentCardsTreeView.Size = new System.Drawing.Size(535, 641);
            this.StudentCardsTreeView.TabIndex = 35;
            this.StudentCardsTreeView.DoubleClick += new System.EventHandler(this.StudentCardsTreeView_DoubleClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(8, 289);
            this.SearchButton.MaximumSize = new System.Drawing.Size(120, 30);
            this.SearchButton.MinimumSize = new System.Drawing.Size(120, 30);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(120, 30);
            this.SearchButton.TabIndex = 36;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SurnameSearchTextBox
            // 
            this.SurnameSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameSearchTextBox.Location = new System.Drawing.Point(8, 74);
            this.SurnameSearchTextBox.Name = "SurnameSearchTextBox";
            this.SurnameSearchTextBox.Size = new System.Drawing.Size(292, 29);
            this.SurnameSearchTextBox.TabIndex = 37;
            this.SurnameSearchTextBox.TextChanged += new System.EventHandler(this.SurnameSearchTextBox_TextChanged);
            // 
            // NameSearchTextBox
            // 
            this.NameSearchTextBox.Enabled = false;
            this.NameSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSearchTextBox.Location = new System.Drawing.Point(8, 133);
            this.NameSearchTextBox.Name = "NameSearchTextBox";
            this.NameSearchTextBox.Size = new System.Drawing.Size(292, 29);
            this.NameSearchTextBox.TabIndex = 38;
            this.NameSearchTextBox.TextChanged += new System.EventHandler(this.NameSearchTextBox_TextChanged);
            // 
            // MidNameSearchTextBox
            // 
            this.MidNameSearchTextBox.Enabled = false;
            this.MidNameSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MidNameSearchTextBox.Location = new System.Drawing.Point(8, 192);
            this.MidNameSearchTextBox.Name = "MidNameSearchTextBox";
            this.MidNameSearchTextBox.Size = new System.Drawing.Size(292, 29);
            this.MidNameSearchTextBox.TabIndex = 39;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(85, 10);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(117, 39);
            this.SearchLabel.TabIndex = 40;
            this.SearchLabel.Text = "Поиск";
            // 
            // SurnameSearchLabel
            // 
            this.SurnameSearchLabel.AutoSize = true;
            this.SurnameSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameSearchLabel.Location = new System.Drawing.Point(4, 47);
            this.SurnameSearchLabel.Name = "SurnameSearchLabel";
            this.SurnameSearchLabel.Size = new System.Drawing.Size(91, 24);
            this.SurnameSearchLabel.TabIndex = 41;
            this.SurnameSearchLabel.Text = "Фамилия";
            // 
            // NameSearchLabel
            // 
            this.NameSearchLabel.AutoSize = true;
            this.NameSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSearchLabel.Location = new System.Drawing.Point(4, 106);
            this.NameSearchLabel.Name = "NameSearchLabel";
            this.NameSearchLabel.Size = new System.Drawing.Size(46, 24);
            this.NameSearchLabel.TabIndex = 42;
            this.NameSearchLabel.Text = "Имя";
            // 
            // MidNameSearchLabel
            // 
            this.MidNameSearchLabel.AutoSize = true;
            this.MidNameSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MidNameSearchLabel.Location = new System.Drawing.Point(4, 165);
            this.MidNameSearchLabel.Name = "MidNameSearchLabel";
            this.MidNameSearchLabel.Size = new System.Drawing.Size(98, 24);
            this.MidNameSearchLabel.TabIndex = 43;
            this.MidNameSearchLabel.Text = "Отчество";
            // 
            // DeleteSearchButton
            // 
            this.DeleteSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSearchButton.Location = new System.Drawing.Point(180, 289);
            this.DeleteSearchButton.MaximumSize = new System.Drawing.Size(120, 30);
            this.DeleteSearchButton.MinimumSize = new System.Drawing.Size(120, 30);
            this.DeleteSearchButton.Name = "DeleteSearchButton";
            this.DeleteSearchButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteSearchButton.TabIndex = 44;
            this.DeleteSearchButton.Text = "Очистить";
            this.DeleteSearchButton.UseVisualStyleBackColor = true;
            this.DeleteSearchButton.Click += new System.EventHandler(this.DeleteSearchButton_Click);
            // 
            // CourceLabel
            // 
            this.CourceLabel.AutoSize = true;
            this.CourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CourceLabel.Location = new System.Drawing.Point(4, 224);
            this.CourceLabel.Name = "CourceLabel";
            this.CourceLabel.Size = new System.Drawing.Size(52, 24);
            this.CourceLabel.TabIndex = 46;
            this.CourceLabel.Text = "Курс";
            // 
            // CourceSearchComboBox
            // 
            this.CourceSearchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CourceSearchComboBox.FormattingEnabled = true;
            this.CourceSearchComboBox.Location = new System.Drawing.Point(8, 251);
            this.CourceSearchComboBox.Name = "CourceSearchComboBox";
            this.CourceSearchComboBox.Size = new System.Drawing.Size(121, 32);
            this.CourceSearchComboBox.TabIndex = 45;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(845, 396);
            this.AddButton.MaximumSize = new System.Drawing.Size(175, 30);
            this.AddButton.MinimumSize = new System.Drawing.Size(175, 30);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(175, 30);
            this.AddButton.TabIndex = 47;
            this.AddButton.Text = "Добавить новую карточку";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(1208, 396);
            this.DeleteButton.MaximumSize = new System.Drawing.Size(175, 30);
            this.DeleteButton.MinimumSize = new System.Drawing.Size(175, 30);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(175, 30);
            this.DeleteButton.TabIndex = 48;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoPictureBox.Location = new System.Drawing.Point(1206, 10);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(166, 194);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoPictureBox.TabIndex = 71;
            this.PhotoPictureBox.TabStop = false;
            // 
            // TelefonNumberLabel
            // 
            this.TelefonNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TelefonNumberLabel.AutoSize = true;
            this.TelefonNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelefonNumberLabel.Location = new System.Drawing.Point(842, 275);
            this.TelefonNumberLabel.Name = "TelefonNumberLabel";
            this.TelefonNumberLabel.Size = new System.Drawing.Size(273, 24);
            this.TelefonNumberLabel.TabIndex = 64;
            this.TelefonNumberLabel.Text = "Контактный номер телефона";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(842, 334);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(248, 24);
            this.EmailLabel.TabIndex = 63;
            this.EmailLabel.Text = "Адрес электронной почты";
            // 
            // TelefonTextBox
            // 
            this.TelefonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TelefonTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TelefonTextBox.Enabled = false;
            this.TelefonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelefonTextBox.Location = new System.Drawing.Point(846, 302);
            this.TelefonTextBox.Name = "TelefonTextBox";
            this.TelefonTextBox.Size = new System.Drawing.Size(536, 29);
            this.TelefonTextBox.TabIndex = 62;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EmailTextBox.Enabled = false;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(846, 361);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(537, 29);
            this.EmailTextBox.TabIndex = 61;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.Location = new System.Drawing.Point(842, 246);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(67, 24);
            this.AddressLabel.TabIndex = 60;
            this.AddressLabel.Text = "Адрес";
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.Location = new System.Drawing.Point(842, 211);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(66, 24);
            this.CityLabel.TabIndex = 59;
            this.CityLabel.Text = "Город";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.AddressTextBox.Enabled = false;
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressTextBox.Location = new System.Drawing.Point(946, 243);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(437, 29);
            this.AddressTextBox.TabIndex = 58;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CityTextBox.Enabled = false;
            this.CityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityTextBox.Location = new System.Drawing.Point(946, 208);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(437, 29);
            this.CityTextBox.TabIndex = 57;
            // 
            // MiddlenameTextBox
            // 
            this.MiddlenameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiddlenameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MiddlenameTextBox.Enabled = false;
            this.MiddlenameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddlenameTextBox.Location = new System.Drawing.Point(946, 173);
            this.MiddlenameTextBox.Name = "MiddlenameTextBox";
            this.MiddlenameTextBox.Size = new System.Drawing.Size(254, 29);
            this.MiddlenameTextBox.TabIndex = 56;
            // 
            // MiddlenameLabel
            // 
            this.MiddlenameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiddlenameLabel.AutoSize = true;
            this.MiddlenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddlenameLabel.Location = new System.Drawing.Point(842, 176);
            this.MiddlenameLabel.Name = "MiddlenameLabel";
            this.MiddlenameLabel.Size = new System.Drawing.Size(98, 24);
            this.MiddlenameLabel.TabIndex = 55;
            this.MiddlenameLabel.Text = "Отчество";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(842, 141);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(46, 24);
            this.NameLabel.TabIndex = 52;
            this.NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(946, 138);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(254, 29);
            this.NameTextBox.TabIndex = 51;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(842, 106);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(91, 24);
            this.SurnameLabel.TabIndex = 50;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SurnameTextBox.Enabled = false;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(946, 103);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(254, 29);
            this.SurnameTextBox.TabIndex = 49;
            // 
            // ChangeInfoButton
            // 
            this.ChangeInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeInfoButton.Location = new System.Drawing.Point(1027, 396);
            this.ChangeInfoButton.MaximumSize = new System.Drawing.Size(175, 30);
            this.ChangeInfoButton.MinimumSize = new System.Drawing.Size(175, 30);
            this.ChangeInfoButton.Name = "ChangeInfoButton";
            this.ChangeInfoButton.Size = new System.Drawing.Size(175, 30);
            this.ChangeInfoButton.TabIndex = 76;
            this.ChangeInfoButton.Text = "Изменить";
            this.ChangeInfoButton.UseVisualStyleBackColor = true;
            this.ChangeInfoButton.Click += new System.EventHandler(this.ChangeInfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(843, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 37);
            this.label1.TabIndex = 77;
            this.label1.Text = "Информация о студенте";
            // 
            // StudentTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeInfoButton);
            this.Controls.Add(this.PhotoPictureBox);
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
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CourceLabel);
            this.Controls.Add(this.CourceSearchComboBox);
            this.Controls.Add(this.DeleteSearchButton);
            this.Controls.Add(this.MidNameSearchLabel);
            this.Controls.Add(this.NameSearchLabel);
            this.Controls.Add(this.SurnameSearchLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.MidNameSearchTextBox);
            this.Controls.Add(this.NameSearchTextBox);
            this.Controls.Add(this.SurnameSearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StudentCardsTreeView);
            this.MinimumSize = new System.Drawing.Size(1410, 700);
            this.Name = "StudentTable";
            this.Text = "Список студентов";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView StudentCardsTreeView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SurnameSearchTextBox;
        private System.Windows.Forms.TextBox NameSearchTextBox;
        private System.Windows.Forms.TextBox MidNameSearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label SurnameSearchLabel;
        private System.Windows.Forms.Label NameSearchLabel;
        private System.Windows.Forms.Label MidNameSearchLabel;
        private System.Windows.Forms.Button DeleteSearchButton;
        private System.Windows.Forms.Label CourceLabel;
        private System.Windows.Forms.ComboBox CourceSearchComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Label TelefonNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox TelefonTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox MiddlenameTextBox;
        private System.Windows.Forms.Label MiddlenameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Button ChangeInfoButton;
        private System.Windows.Forms.Label label1;
    }
}