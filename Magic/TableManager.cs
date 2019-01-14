using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Magic
{
    public partial class TableManager : Form
    {
        public void FacultyFilter(ComboBox facultyComboBox, DataGridView studentListDataGridView)
        {
            var currentFaculty = (Faculty)facultyComboBox.SelectedItem;
            var studentList = new StudentForTable().LoadInfoToTable();
            var currentStudentList = new List<StudentForTable>();

            if (currentFaculty != null)
            {
                currentStudentList.Clear();
                studentListDataGridView.DataSource = null;
                studentListDataGridView.Refresh();
                foreach (StudentForTable student in studentList)
                {
                    if (student.FacultyName == currentFaculty.Name)
                    {
                        currentStudentList.Add(student);
                    }
                }
                studentListDataGridView.DataSource = currentStudentList;
                RenameColumnsNames(studentListDataGridView);
            }
        }

        public void SpecialityFilter(ComboBox facultyComboBox, ComboBox specialityComboBox, DataGridView studentListDataGridView)
        {
            var currentSpeciality = (Speciality)specialityComboBox.SelectedItem;
            var currentFaculty = (Faculty)facultyComboBox.SelectedItem;
            var studentList = new StudentForTable().LoadInfoToTable();
            var currentStudentList = new List<StudentForTable>();

            currentStudentList.Clear();
            studentListDataGridView.DataSource = null;
            studentListDataGridView.Refresh();

            if (currentSpeciality != null)
            {
                foreach (StudentForTable student in studentList)
                {
                    if (student.SpecialityName == currentSpeciality.Name && student.FacultyName == currentFaculty.Name)
                    {
                        currentStudentList.Add(student);
                    }
                }
                studentListDataGridView.DataSource = currentStudentList;
                RenameColumnsNames(studentListDataGridView);
            }
        }

        public void CourceFilter(ComboBox facultyComboBox, ComboBox specialityComboBox, ComboBox courceComboBox, DataGridView studentListDataGridView)
        {
            var currentCource = (Cource)courceComboBox.SelectedItem;
            var currentSpeciality = (Speciality)specialityComboBox.SelectedItem;
            var currentFaculty = (Faculty)facultyComboBox.SelectedItem;
            var studentList = new StudentForTable().LoadInfoToTable();
            var currentStudentList = new List<StudentForTable>();

            currentStudentList.Clear();
            studentListDataGridView.DataSource = null;
            studentListDataGridView.Refresh();

            if (currentCource != null)
            {
                foreach (StudentForTable student in studentList)
                {
                    if (student.CourceNumber == currentCource.Number && student.SpecialityName == currentSpeciality.Name && student.FacultyName == currentFaculty.Name)
                    {
                        currentStudentList.Add(student);
                    }
                }
                studentListDataGridView.DataSource = currentStudentList;
                RenameColumnsNames(studentListDataGridView);
            }
        }

        public void GroupFilter(ComboBox facultyComboBox, ComboBox specialityComboBox, ComboBox courceComboBox, ComboBox groupComboBox, DataGridView studentListDataGridView)
        {
            var currentGroup = (Group)groupComboBox.SelectedItem;
            var currentCource = (Cource)courceComboBox.SelectedItem;
            var currentSpeciality = (Speciality)specialityComboBox.SelectedItem;
            var currentFaculty = (Faculty)facultyComboBox.SelectedItem;

            var studentList = new StudentForTable().LoadInfoToTable();
            var currentStudentList = new List<StudentForTable>();

            currentStudentList.Clear();
            studentListDataGridView.DataSource = null;
            studentListDataGridView.Refresh();

            if (currentGroup != null)
            {
                foreach (StudentForTable student in studentList)
                {
                    if (student.GroupName == currentGroup.Name && student.CourceNumber == currentCource.Number && student.SpecialityName == currentSpeciality.Name && student.FacultyName == currentFaculty.Name)
                    {
                        currentStudentList.Add(student);
                    }
                }
                studentListDataGridView.DataSource = currentStudentList;
                RenameColumnsNames(studentListDataGridView);
            }
        }

        public void LoadFullInfo(DataGridView studentListDataGridView)
        {
            var studentListForTable = new StudentForTable().LoadInfoToTable();
            studentListDataGridView.DataSource = studentListForTable;
            RenameColumnsNames(studentListDataGridView);
        }

        private void RenameColumnsNames(DataGridView studentListDataGridView)
        {
            studentListDataGridView.Columns[0].HeaderText = "Фамилия";
            studentListDataGridView.Columns[1].HeaderText = "Имя";
            studentListDataGridView.Columns[2].HeaderText = "Отчество";
            studentListDataGridView.Columns[3].HeaderText = "Город";
            studentListDataGridView.Columns[4].HeaderText = "Адрес";
            studentListDataGridView.Columns[5].HeaderText = "Номер телефона";
            studentListDataGridView.Columns[6].HeaderText = "Email";
            studentListDataGridView.Columns[7].HeaderText = "Факультет";
            studentListDataGridView.Columns[8].HeaderText = "Специальность";
            studentListDataGridView.Columns[9].HeaderText = "Группа";
            studentListDataGridView.Columns[10].HeaderText = "Курс";
        }
    }
}