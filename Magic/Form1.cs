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

            student.Surname = surNameTextBox.Text;
            student.Name = nameTextBox.Text;

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
            surNameTextBox.Text = student.Surname;
            nameTextBox.Text = student.Name;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CreateFacultyComboBox()
        {
            var curriculumInfo = new Curriculum().LoadCurruculumData();
            var faculties = new List<string>();
            for (var i = 0; i < curriculumInfo.Faculties.Count; i++)
            {
                faculties.Add(curriculumInfo.Faculties[i].Name);
            }
            foreach (var faculty in faculties)
            {
                //ComboBoxItem item = new ComboBoxItem();
                //item.Text = faculty;
                facultyComboBox.Items.Add(faculty);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateFacultyComboBox();
        }

        // сделать отдельный файл с инфой по факультетам и т.д.; сделать комбобоксы с добавленной институтской инфой;
    }
}