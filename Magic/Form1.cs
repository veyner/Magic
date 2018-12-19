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

namespace Magic
{
    public partial class StudentCard : Form
    {
        public StudentCard()
        {
            InitializeComponent();
            LoadDataToComboBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var student = new SaveNLoadManager().LoadData(Properties.Settings.Default.PathToData);
        }

        public void ChangeTextBoxes(Student student)
        {
            surnameTextBox.Text = student.Surname;
            nameTextBox.Text = student.Name;
            middlenameTextBox.Text = student.Name;
            cityTextBox.Text = student.City;
            streetTextBox.Text = student.Street;
            telefonTextBox.Text = student.TelefonNumber.ToString();
            emailTextBox.Text = student.Email;

            facultyComboBox.ValueMember = nameof(Faculty.ID);
            facultyComboBox.SelectedValue = student.FacultyID;

            specialityComboBox.ValueMember = nameof(Speciality.ID);
            specialityComboBox.SelectedValue = student.SpecialityID;

            courceComboBox.ValueMember = nameof(Cource.Number);
            courceComboBox.SelectedValue = student.Cource;

            groupComboBox.ValueMember = nameof(Group.ID);
            groupComboBox.SelectedValue = student.GroupID;
        }

        private void LoadDataToComboBoxes()
        {
            var curriculumInfo = new Curriculum().LoadCurruculumData();

            facultyComboBox.DataSource = curriculumInfo.Faculties;
            facultyComboBox.DisplayMember = "Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void facultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentFaculty = (Faculty)facultyComboBox.SelectedItem;
            specialityComboBox.DataSource = currentFaculty.Specialities;
            specialityComboBox.DisplayMember = "Name";
        }

        private void specialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentSpeciality = (Speciality)specialityComboBox.SelectedItem;
            courceComboBox.DataSource = currentSpeciality.Cources;
            courceComboBox.DisplayMember = "Number";
        }

        private void courceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentCource = (Cource)courceComboBox.SelectedItem;
            groupComboBox.DataSource = currentCource.Groups;
            groupComboBox.DisplayMember = "Name";
        }

        private void saveStudentCardButton_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var currentFaculty = (Faculty)facultyComboBox.SelectedItem;
            var currentSpeciality = (Speciality)specialityComboBox.SelectedItem;
            var currentCource = (Cource)courceComboBox.SelectedItem;
            var currentGroup = (Group)groupComboBox.SelectedItem;

            student.Surname = surnameTextBox.Text;
            student.Name = nameTextBox.Text;
            student.MiddleName = middlenameTextBox.Text;
            student.City = cityTextBox.Text;
            student.Street = streetTextBox.Text;
            student.TelefonNumber = long.Parse(telefonTextBox.Text);
            student.Email = emailTextBox.Text;
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

        // ++сделать отдельный файл с инфой по факультетам и т.д.; сделать комбобоксы с добавленной институтской инфой;
        // ++закрепление curriculum info за студентом в виде ID. сохранение каждой карточки в отдельный файл json.
    }
}