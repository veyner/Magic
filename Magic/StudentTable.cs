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

        private void StudentTable_Load(object sender, EventArgs e)
        {
            var studentData = LoadStudentData();
            dataGridView1.DataSource = studentData;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var adress = dataGridView1.CurrentCellAddress;
            var currentStudentNumber = adress.Y;
            LoadClickedStudent(currentStudentNumber);
        }

        private void LoadClickedStudent(int currentStudentNumber)
        {
            var studentData = LoadStudentData();
            var currentStudent = studentData[currentStudentNumber];
            var currentStudentCard = new StudentCard();
            currentStudentCard.ChangeTextBoxes(currentStudent);
            currentStudentCard.Show();
        }

        private List<Student> LoadStudentData()
        {
            return new SaveNLoadManager().GetStudents(Properties.Settings.Default.PathToData);
        }
    }
}