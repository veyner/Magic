using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using Newtonsoft.Json;

namespace StudentCard
{
    public partial class StudentCard : Form
    {
        public StudentCard()
        {
            InitializeComponent();
            new ComboBoxManager().LoadInfoToFacultyCombobox(FacultyComboBox);
            new ComboBoxManager().LoadInfoToCourceComboBox(CourceComboBox);
        }

        public void ChangeTextBoxes(Student student)
        {
            SurnameTextBox.Text = student.Surname;
            NameTextBox.Text = student.Names;
            MiddlenameTextBox.Text = student.Names;
            CityTextBox.Text = student.City;
            StreetTextBox.Text = student.Street;
            TelefonTextBox.Text = student.TelefonNumber.ToString();
            EmailTextBox.Text = student.Email;

            FacultyComboBox.ValueMember = nameof(Faculty.ID);
            FacultyComboBox.SelectedValue = student.FacultyID;

            SpecialityComboBox.ValueMember = nameof(Speciality.ID);
            SpecialityComboBox.SelectedValue = student.SpecialityID;

            CourceComboBox.ValueMember = nameof(Cource.Number);
            CourceComboBox.SelectedValue = student.Cource;

            GroupComboBox.ValueMember = nameof(Group.ID);
            GroupComboBox.SelectedValue = student.GroupID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void facultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToSpecialityComboBox(SpecialityComboBox, FacultyComboBox);
        }

        private void specialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToGroupComboBox(GroupComboBox, SpecialityComboBox);
        }

        private void courceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void saveStudentCardButton_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;
            var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
            var currentCource = (Cource)CourceComboBox.SelectedItem;
            var currentGroup = (Group)GroupComboBox.SelectedItem;

            student.Surname = SurnameTextBox.Text;
            student.Names = NameTextBox.Text;
            student.MiddleName = MiddlenameTextBox.Text;
            student.City = CityTextBox.Text;
            student.Street = StreetTextBox.Text;
            student.TelefonNumber = long.Parse(TelefonTextBox.Text);
            student.Email = EmailTextBox.Text;
            student.FacultyID = currentFaculty.ID;
            student.SpecialityID = currentSpeciality.ID;
            student.Cource = currentCource.Number;
            student.GroupID = currentGroup.ID;
            new SaveNLoadManager().SaveData(student);
            MessageBox.Show($"Данные {student.Surname} сохранены");
        }

        private void showStudentListbutton_Click(object sender, EventArgs e)
        {
            new StudentTable().Show();
        }
    }
}