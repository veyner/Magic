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
            this.CourceComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentCardsTreeView
            // 
            this.StudentCardsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentCardsTreeView.Location = new System.Drawing.Point(12, 12);
            this.StudentCardsTreeView.Name = "StudentCardsTreeView";
            this.StudentCardsTreeView.Size = new System.Drawing.Size(339, 421);
            this.StudentCardsTreeView.TabIndex = 35;
            this.StudentCardsTreeView.DoubleClick += new System.EventHandler(this.StudentCardsTreeView_DoubleClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(386, 194);
            this.SearchButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.SearchButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 36;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SurnameSearchTextBox
            // 
            this.SurnameSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameSearchTextBox.Location = new System.Drawing.Point(386, 50);
            this.SurnameSearchTextBox.Name = "SurnameSearchTextBox";
            this.SurnameSearchTextBox.Size = new System.Drawing.Size(170, 20);
            this.SurnameSearchTextBox.TabIndex = 37;
            // 
            // NameSearchTextBox
            // 
            this.NameSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameSearchTextBox.Location = new System.Drawing.Point(386, 89);
            this.NameSearchTextBox.Name = "NameSearchTextBox";
            this.NameSearchTextBox.Size = new System.Drawing.Size(170, 20);
            this.NameSearchTextBox.TabIndex = 38;
            // 
            // MidNameSearchTextBox
            // 
            this.MidNameSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MidNameSearchTextBox.Location = new System.Drawing.Point(386, 128);
            this.MidNameSearchTextBox.Name = "MidNameSearchTextBox";
            this.MidNameSearchTextBox.Size = new System.Drawing.Size(170, 20);
            this.MidNameSearchTextBox.TabIndex = 39;
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(383, 12);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(39, 13);
            this.SearchLabel.TabIndex = 40;
            this.SearchLabel.Text = "Поиск";
            // 
            // SurnameSearchLabel
            // 
            this.SurnameSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameSearchLabel.AutoSize = true;
            this.SurnameSearchLabel.Location = new System.Drawing.Point(383, 34);
            this.SurnameSearchLabel.Name = "SurnameSearchLabel";
            this.SurnameSearchLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameSearchLabel.TabIndex = 41;
            this.SurnameSearchLabel.Text = "Фамилия";
            // 
            // NameSearchLabel
            // 
            this.NameSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameSearchLabel.AutoSize = true;
            this.NameSearchLabel.Location = new System.Drawing.Point(383, 73);
            this.NameSearchLabel.Name = "NameSearchLabel";
            this.NameSearchLabel.Size = new System.Drawing.Size(29, 13);
            this.NameSearchLabel.TabIndex = 42;
            this.NameSearchLabel.Text = "Имя";
            // 
            // MidNameSearchLabel
            // 
            this.MidNameSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MidNameSearchLabel.AutoSize = true;
            this.MidNameSearchLabel.Location = new System.Drawing.Point(383, 112);
            this.MidNameSearchLabel.Name = "MidNameSearchLabel";
            this.MidNameSearchLabel.Size = new System.Drawing.Size(54, 13);
            this.MidNameSearchLabel.TabIndex = 43;
            this.MidNameSearchLabel.Text = "Отчество";
            // 
            // DeleteSearchButton
            // 
            this.DeleteSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSearchButton.Location = new System.Drawing.Point(481, 194);
            this.DeleteSearchButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.DeleteSearchButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.DeleteSearchButton.Name = "DeleteSearchButton";
            this.DeleteSearchButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteSearchButton.TabIndex = 44;
            this.DeleteSearchButton.Text = "Очистить";
            this.DeleteSearchButton.UseVisualStyleBackColor = true;
            this.DeleteSearchButton.Click += new System.EventHandler(this.DeleteSearchButton_Click);
            // 
            // CourceLabel
            // 
            this.CourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CourceLabel.AutoSize = true;
            this.CourceLabel.Location = new System.Drawing.Point(383, 151);
            this.CourceLabel.Name = "CourceLabel";
            this.CourceLabel.Size = new System.Drawing.Size(31, 13);
            this.CourceLabel.TabIndex = 46;
            this.CourceLabel.Text = "Курс";
            // 
            // CourceComboBox
            // 
            this.CourceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CourceComboBox.FormattingEnabled = true;
            this.CourceComboBox.Location = new System.Drawing.Point(386, 167);
            this.CourceComboBox.Name = "CourceComboBox";
            this.CourceComboBox.Size = new System.Drawing.Size(121, 21);
            this.CourceComboBox.TabIndex = 45;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(14, 439);
            this.AddButton.MaximumSize = new System.Drawing.Size(151, 23);
            this.AddButton.MinimumSize = new System.Drawing.Size(151, 23);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(151, 23);
            this.AddButton.TabIndex = 47;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(200, 439);
            this.DeleteButton.MaximumSize = new System.Drawing.Size(151, 23);
            this.DeleteButton.MinimumSize = new System.Drawing.Size(151, 23);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(151, 23);
            this.DeleteButton.TabIndex = 48;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StudentTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 471);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CourceLabel);
            this.Controls.Add(this.CourceComboBox);
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
            this.MinimumSize = new System.Drawing.Size(605, 510);
            this.Name = "StudentTable";
            this.Text = "Список студентов";
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
        private System.Windows.Forms.ComboBox CourceComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}