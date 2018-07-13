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
            if (!Directory.Exists(Properties.Settings.Default.PathToData))
            {
                Directory.CreateDirectory(Properties.Settings.Default.PathToData);
            }
            SaveData(student);
            MessageBox.Show($"Данные {student.Surname} сохранены");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public void SaveData(Student student)
        {
            var fullSavePath = Path.Combine(Properties.Settings.Default.PathToData, student.Surname + ".json");

            using (var writer = new StreamWriter(fullSavePath))
            {
                var json = JsonConvert.SerializeObject(student);
                writer.Write(json);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var student = LoadSave("Hui");
            textBox1.Text = student.Surname;
        }

        public Student LoadSave(string studensSurname)
        {
            var fullDataPath = Path.Combine(Properties.Settings.Default.PathToData, studensSurname + ".json");
            using (var reader = new StreamReader(fullDataPath))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Student>(json);
            }
        }
    }
}