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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = new Student();

            student.Surname = surnameTextBox.Text;
            student.Name = nameTextBox.Text;
            student.MiddleName = middlenameTextBox.Text;
            student.City = cityTextBox.Text;
            student.Street = streetTextBox.Text;
            student.TelefonNumber = int.Parse(telefonTextBox.Text);
            student.Email = emailTextBox.Text;

            new SaveNLoadManager().SaveData(student);
            MessageBox.Show($"Данные {student.Surname} сохранены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var student = new SaveNLoadManager().LoadData(Properties.Settings.Default.PathToData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new StudentTable().Show();
        }

        public void ChangeTextBoxes(Student student)
        {
            surnameTextBox.Text = student.Surname;
            nameTextBox.Text = student.Name;
        }

        private void LoadDataToComboBoxes()
        {
            var curriculumInfo = new Curriculum().LoadCurruculumData();

            facultyComboBox.DataSource = curriculumInfo.Faculties;
            facultyComboBox.DisplayMember = "Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //new Curriculum().SaveData();
            LoadDataToComboBoxes();
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

        // сделать отдельный файл с инфой по факультетам и т.д.; сделать комбобоксы с добавленной институтской инфой;
    }
}