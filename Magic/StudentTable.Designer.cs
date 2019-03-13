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
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(337, 421);
            this.treeView1.TabIndex = 35;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(384, 194);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 36;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SurnameSearchTextBox
            // 
            this.SurnameSearchTextBox.Location = new System.Drawing.Point(384, 50);
            this.SurnameSearchTextBox.Name = "SurnameSearchTextBox";
            this.SurnameSearchTextBox.Size = new System.Drawing.Size(170, 20);
            this.SurnameSearchTextBox.TabIndex = 37;
            // 
            // NameSearchTextBox
            // 
            this.NameSearchTextBox.Location = new System.Drawing.Point(384, 89);
            this.NameSearchTextBox.Name = "NameSearchTextBox";
            this.NameSearchTextBox.Size = new System.Drawing.Size(170, 20);
            this.NameSearchTextBox.TabIndex = 38;
            // 
            // MidNameSearchTextBox
            // 
            this.MidNameSearchTextBox.Location = new System.Drawing.Point(384, 128);
            this.MidNameSearchTextBox.Name = "MidNameSearchTextBox";
            this.MidNameSearchTextBox.Size = new System.Drawing.Size(170, 20);
            this.MidNameSearchTextBox.TabIndex = 39;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(381, 12);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(39, 13);
            this.SearchLabel.TabIndex = 40;
            this.SearchLabel.Text = "Поиск";
            // 
            // SurnameSearchLabel
            // 
            this.SurnameSearchLabel.AutoSize = true;
            this.SurnameSearchLabel.Location = new System.Drawing.Point(381, 34);
            this.SurnameSearchLabel.Name = "SurnameSearchLabel";
            this.SurnameSearchLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameSearchLabel.TabIndex = 41;
            this.SurnameSearchLabel.Text = "Фамилия";
            // 
            // NameSearchLabel
            // 
            this.NameSearchLabel.AutoSize = true;
            this.NameSearchLabel.Location = new System.Drawing.Point(381, 73);
            this.NameSearchLabel.Name = "NameSearchLabel";
            this.NameSearchLabel.Size = new System.Drawing.Size(29, 13);
            this.NameSearchLabel.TabIndex = 42;
            this.NameSearchLabel.Text = "Имя";
            // 
            // MidNameSearchLabel
            // 
            this.MidNameSearchLabel.AutoSize = true;
            this.MidNameSearchLabel.Location = new System.Drawing.Point(381, 112);
            this.MidNameSearchLabel.Name = "MidNameSearchLabel";
            this.MidNameSearchLabel.Size = new System.Drawing.Size(54, 13);
            this.MidNameSearchLabel.TabIndex = 43;
            this.MidNameSearchLabel.Text = "Отчество";
            // 
            // DeleteSearchButton
            // 
            this.DeleteSearchButton.Location = new System.Drawing.Point(479, 194);
            this.DeleteSearchButton.Name = "DeleteSearchButton";
            this.DeleteSearchButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteSearchButton.TabIndex = 44;
            this.DeleteSearchButton.Text = "Очистить";
            this.DeleteSearchButton.UseVisualStyleBackColor = true;
            this.DeleteSearchButton.Click += new System.EventHandler(this.DeleteSearchButton_Click);
            // 
            // CourceLabel
            // 
            this.CourceLabel.AutoSize = true;
            this.CourceLabel.Location = new System.Drawing.Point(381, 151);
            this.CourceLabel.Name = "CourceLabel";
            this.CourceLabel.Size = new System.Drawing.Size(31, 13);
            this.CourceLabel.TabIndex = 46;
            this.CourceLabel.Text = "Курс";
            // 
            // CourceComboBox
            // 
            this.CourceComboBox.FormattingEnabled = true;
            this.CourceComboBox.Location = new System.Drawing.Point(384, 167);
            this.CourceComboBox.Name = "CourceComboBox";
            this.CourceComboBox.Size = new System.Drawing.Size(121, 21);
            this.CourceComboBox.TabIndex = 45;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(384, 241);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 47;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(479, 241);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 48;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StudentTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 485);
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
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentTable";
            this.Text = "Список студентов";
            this.Load += new System.EventHandler(this.StudentTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
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