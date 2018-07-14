using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic
{
    public partial class StudentTable : Form
    {
        public StudentTable()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void StudentTable_Load(object sender, EventArgs e)
        {
            var studentData = new SaveNLoadManager().GetStudents(Properties.Settings.Default.PathToData);
            dataGridView1.DataSource = studentData;
        }
    }
}