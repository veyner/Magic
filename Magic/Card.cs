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
        private StudentTable currentStudentTable;
        private List<Student> currentDataStudent;
        private Student currentStudent;

        public StudentCard(StudentTable studentTable, List<Student> dataStudent)
        {
            currentDataStudent = dataStudent;
            currentStudentTable = studentTable;
            InitializeComponent();
            new ComboBoxManager().LoadInfoToFacultyCombobox(FacultyComboBox);
        }

        //загрузка данных студента в текстбоксы и комбобоксы
        public void ChangeTextBoxes(Student student)
        {
            currentStudent = student;

            SurnameTextBox.Text = student.Surname;
            NameTextBox.Text = student.Names;
            MiddlenameTextBox.Text = student.MiddleName;
            CityTextBox.Text = student.City;
            AddressTextBox.Text = student.Street;
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

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToSpecialityComboBox(SpecialityComboBox, FacultyComboBox);
        }

        private void SpecialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToCourceComboBox(CourceComboBox);
        }

        private void CourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToGroupComboBox(GroupComboBox, SpecialityComboBox, CourceComboBox);
        }

        //удаление файла и сохранение измененного или нового файла студента
        private void SaveStudentCardButton_Click(object sender, EventArgs e)
        {
            if (currentStudent == null)
            {
                currentStudent = new Student
                {
                    Guid = Guid.NewGuid()
                };
                currentDataStudent.Add(currentStudent);
            }
            else
            {
                //new SaveNLoadManager().DeleteData(currentStudent);
                //currentDataStudent.Remove(currentStudent);
            }
            SaveCurrentStudent(currentStudent);
            new SaveNLoadManager().SaveData(currentStudent);
            MessageBox.Show($"Данные {currentStudent.Surname} сохранены");
            //currentDataStudent.Add(currentStudent);
            currentStudentTable.RefreshInfo();
            Close();
        }

        public List<Student> ReturnCurrentStudentList()
        {
            return currentDataStudent;
        }

        //сохранение данных о конкретном студенте
        private void SaveCurrentStudent(Student student)
        {
            var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;
            var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
            var currentCource = (Cource)CourceComboBox.SelectedItem;
            var currentGroup = (Group)GroupComboBox.SelectedItem;

            student.Surname = SurnameTextBox.Text;
            student.Names = NameTextBox.Text;
            student.MiddleName = MiddlenameTextBox.Text;
            student.City = CityTextBox.Text;
            student.Street = AddressTextBox.Text;
            student.TelefonNumber = long.Parse(TelefonTextBox.Text);
            student.Email = EmailTextBox.Text;
            student.FacultyID = currentFaculty.ID;
            student.SpecialityID = currentSpeciality.ID;
            student.Cource = currentCource.Number;
            student.GroupID = currentGroup.ID;
            if (FotoPictureBox.Image != null)
            {
                student.Foto = true;
                FotoPictureBox.Image.Save(Path.Combine(Magic.Properties.Settings.Default.PathToFoto, student.Guid.ToString() + ".jpg"));
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            AllowChanges();
        }

        //запрет на изменение данных в карточке
        public void LockChanges()
        {
            FotoPictureBox.Enabled = false;
            SurnameTextBox.ReadOnly = true;
            NameTextBox.ReadOnly = true;
            MiddlenameTextBox.ReadOnly = true;
            CityTextBox.ReadOnly = true;
            AddressTextBox.ReadOnly = true;
            TelefonTextBox.ReadOnly = true;
            EmailTextBox.ReadOnly = true;

            FacultyComboBox.Enabled = false;
            SpecialityComboBox.Enabled = false;
            CourceComboBox.Enabled = false;
            GroupComboBox.Enabled = false;
        }

        //позволяет изменять данные в карточке
        public void AllowChanges()
        {
            FotoPictureBox.Enabled = true;
            SurnameTextBox.ReadOnly = false;
            NameTextBox.ReadOnly = false;
            MiddlenameTextBox.ReadOnly = false;
            CityTextBox.ReadOnly = false;
            AddressTextBox.ReadOnly = false;
            TelefonTextBox.ReadOnly = false;
            EmailTextBox.ReadOnly = false;

            FacultyComboBox.Enabled = true;
            SpecialityComboBox.Enabled = true;
            CourceComboBox.Enabled = true;
            GroupComboBox.Enabled = true;
        }

        public void LoadFoto(Student student)
        {
            FotoPictureBox.ImageLocation = Path.Combine(Magic.Properties.Settings.Default.PathToFoto, student.Guid + ".jpg");
        }

        private void FotoPictureBox_Click(object sender, EventArgs e)
        {
            if (FotoOpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = FotoOpenFileDialog.FileName;
            FotoPictureBox.ImageLocation = filename;
        }
    }
}