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
            this.studentListDataGridView = new System.Windows.Forms.DataGridView();
            this.courceLabel = new System.Windows.Forms.Label();
            this.specialityLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.courceComboBox = new System.Windows.Forms.ComboBox();
            this.specialityComboBox = new System.Windows.Forms.ComboBox();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.facultyComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentListDataGridView
            // 
            this.studentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.studentListDataGridView.Name = "studentListDataGridView";
            this.studentListDataGridView.ReadOnly = true;
            this.studentListDataGridView.Size = new System.Drawing.Size(1160, 420);
            this.studentListDataGridView.TabIndex = 0;
            this.studentListDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentListDataGridView_CellMouseDoubleClick);
            // 
            // courceLabel
            // 
            this.courceLabel.AutoSize = true;
            this.courceLabel.Location = new System.Drawing.Point(266, 436);
            this.courceLabel.Name = "courceLabel";
            this.courceLabel.Size = new System.Drawing.Size(31, 13);
            this.courceLabel.TabIndex = 32;
            this.courceLabel.Text = "Курс";
            // 
            // specialityLabel
            // 
            this.specialityLabel.AutoSize = true;
            this.specialityLabel.Location = new System.Drawing.Point(139, 436);
            this.specialityLabel.Name = "specialityLabel";
            this.specialityLabel.Size = new System.Drawing.Size(85, 13);
            this.specialityLabel.TabIndex = 31;
            this.specialityLabel.Text = "Специальность";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(393, 435);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(42, 13);
            this.groupLabel.TabIndex = 30;
            this.groupLabel.Text = "Группа";
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(396, 451);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupComboBox.TabIndex = 29;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // courceComboBox
            // 
            this.courceComboBox.FormattingEnabled = true;
            this.courceComboBox.Location = new System.Drawing.Point(269, 451);
            this.courceComboBox.Name = "courceComboBox";
            this.courceComboBox.Size = new System.Drawing.Size(121, 21);
            this.courceComboBox.TabIndex = 28;
            this.courceComboBox.SelectedIndexChanged += new System.EventHandler(this.courceComboBox_SelectedIndexChanged);
            // 
            // specialityComboBox
            // 
            this.specialityComboBox.FormattingEnabled = true;
            this.specialityComboBox.Location = new System.Drawing.Point(142, 451);
            this.specialityComboBox.Name = "specialityComboBox";
            this.specialityComboBox.Size = new System.Drawing.Size(121, 21);
            this.specialityComboBox.TabIndex = 27;
            this.specialityComboBox.SelectedIndexChanged += new System.EventHandler(this.specialityComboBox_SelectedIndexChanged);
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Location = new System.Drawing.Point(12, 438);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(63, 13);
            this.facultyLabel.TabIndex = 26;
            this.facultyLabel.Text = "Факультет";
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.FormattingEnabled = true;
            this.facultyComboBox.Location = new System.Drawing.Point(15, 451);
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(121, 21);
            this.facultyComboBox.TabIndex = 25;
            this.facultyComboBox.SelectedIndexChanged += new System.EventHandler(this.facultyComboBox_SelectedIndexChanged);
            // 
            // StudentTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 502);
            this.Controls.Add(this.courceLabel);
            this.Controls.Add(this.specialityLabel);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.courceComboBox);
            this.Controls.Add(this.specialityComboBox);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.facultyComboBox);
            this.Controls.Add(this.studentListDataGridView);
            this.Name = "StudentTable";
            this.Text = "StudentTable";
            this.Load += new System.EventHandler(this.StudentTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentListDataGridView;
        private System.Windows.Forms.Label courceLabel;
        private System.Windows.Forms.Label specialityLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox courceComboBox;
        private System.Windows.Forms.ComboBox specialityComboBox;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.ComboBox facultyComboBox;
    }
}