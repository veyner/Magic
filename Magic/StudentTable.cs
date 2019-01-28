using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCard
{
    public partial class StudentTable : Form
    {
        public StudentTable()
        {
            InitializeComponent();
            new ComboBoxManager().LoadInfoToFacultyCombobox(FacultyComboBox);
            new ComboBoxManager().LoadInfoToCourceComboBox(CourceComboBox);
        }

        private void StudentTable_Load(object sender, EventArgs e)
        {
            new TableManager().LoadFullInfo(StudentListDataGridView);
        }

        private void LoadClickedStudent(int currentStudentNumber)
        {
            if (currentStudentNumber != -1)
            {
                var studentData = new SaveNLoadManager().LoadStudentData();
                var currentStudent = studentData[currentStudentNumber];
                var currentStudentCard = new StudentCard();
                currentStudentCard.ChangeTextBoxes(currentStudent);
                currentStudentCard.Show();
            }
        }

        private void studentListDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var address = StudentListDataGridView.CurrentCellAddress;
            var currentStudentNumber = address.Y;
            LoadClickedStudent(currentStudentNumber);
        }

        private void facultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToSpecialityComboBox(SpecialityComboBox, FacultyComboBox);
            var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;

            if (currentFaculty.ID == 0)
            {
                new TableManager().LoadFullInfo(StudentListDataGridView);
            }
            else
            {
                var currentStudentList = new TableManager().FacultyFilter(currentFaculty);
                StudentListDataGridView.DataSource = currentStudentList;
            }
        }

        private void specialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToGroupComboBox(GroupComboBox, SpecialityComboBox);
            var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
            var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;
            if (currentSpeciality.ID == 0)
            {
                var facultyStudentList = new TableManager().FacultyFilter(currentFaculty);
                StudentListDataGridView.DataSource = facultyStudentList;
            }
            else
            {
                var currentStudentList = new TableManager().SpecialityFilter(currentSpeciality);
                StudentListDataGridView.DataSource = currentStudentList;
            }
        }

        private void courceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;
            var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
            var currentGroup = (Group)GroupComboBox.SelectedItem;
            var currentCource = (Cource)CourceComboBox.SelectedItem;

            var currentStudentList = new TableManager().CourceFilter(currentCource, currentFaculty, currentSpeciality, currentGroup);
            StudentListDataGridView.DataSource = currentStudentList;
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentGroup = (Group)GroupComboBox.SelectedItem;
            var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
            if (currentGroup.ID == 0)
            {
                var specialityStudentList = new TableManager().SpecialityFilter(currentSpeciality);
                StudentListDataGridView.DataSource = specialityStudentList;
            }
            else
            {
                var currentStudentList = new TableManager().GroupFilter(currentGroup);
                StudentListDataGridView.DataSource = currentStudentList;
            }
        }

        private void LoadNewStudentCardButton_Click(object sender, EventArgs e)
        {
            new StudentCard().Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var address = StudentListDataGridView.CurrentCellAddress;
            var currentStudentNumber = address.Y;
            if (currentStudentNumber != -1)
            {
                var studentData = new SaveNLoadManager().LoadStudentData();
                var currentStudent = studentData[currentStudentNumber];

                new SaveNLoadManager().DeleteData(currentStudent);

                MessageBox.Show($"Данные {currentStudent.Surname} удалены");
            }
        }
    }
}