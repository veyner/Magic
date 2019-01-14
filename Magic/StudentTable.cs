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
            new ComboBoxManager().LoadInfoToFacultyCombobox(facultyComboBox);
        }

        private void StudentTable_Load(object sender, EventArgs e)
        {
            new TableManager().LoadFullInfo(studentListDataGridView);
        }

        private void LoadClickedStudent(int currentStudentNumber)
        {
            var studentData = new SaveNLoadManager().LoadStudentData();
            var currentStudent = studentData[currentStudentNumber];
            var currentStudentCard = new StudentCard();
            currentStudentCard.ChangeTextBoxes(currentStudent);
            currentStudentCard.Show();
        }

        private void studentListDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var address = studentListDataGridView.CurrentCellAddress;
            var currentStudentNumber = address.Y;
            LoadClickedStudent(currentStudentNumber);
        }

        private void facultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToSpecialityComboBox(specialityComboBox, facultyComboBox);
            new TableManager().FacultyFilter(facultyComboBox, studentListDataGridView);
        }

        private void specialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToCourceComboBox(courceComboBox, specialityComboBox);
            new TableManager().SpecialityFilter(facultyComboBox, specialityComboBox, studentListDataGridView);
        }

        private void courceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToGroupComboBox(groupComboBox, courceComboBox);
            new TableManager().CourceFilter(facultyComboBox, specialityComboBox, courceComboBox, studentListDataGridView);
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new TableManager().GroupFilter(facultyComboBox, specialityComboBox, courceComboBox, groupComboBox, studentListDataGridView);
        }
    }
}