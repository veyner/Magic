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
using Newtonsoft.Json;

namespace Magic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = new Student();

            student.Surname = textBox1.Text;
            student.Name = textBox2.Text;

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
            textBox1.Text = student.Surname;
            textBox2.Text = student.Name;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Form1().CreateFacultyComboBox();
        }

        private void CreateFacultyComboBox()
        {
            var curriculumInfo = new Curriculum().LoadCurruculumData();
            var faculties = new List<string>();
            for (var i = 0; i < curriculumInfo.Faculties.Count; i++)
            {
                faculties.Add(curriculumInfo.Faculties[i].Name);
            }
            FacultyComboBox.DataSource = faculties;
        }

        // сделать отдельный файл с инфой по факультетам и т.д.; сделать комбобоксы с добавленной институтской инфой;
    }
}