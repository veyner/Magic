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
        private StudentTable _studentTable;
        private List<Student> _dataStudent;
        private Student _student;
        private ComboBoxManager _comboBoxManager;
        private SaveNLoadManager _manager;

        public StudentCard(StudentTable studentTable, List<Student> dataStudent)
        {
            _dataStudent = dataStudent;
            _studentTable = studentTable;
            InitializeComponent();
            _comboBoxManager = new ComboBoxManager();
            _manager = new SaveNLoadManager();
            _comboBoxManager.LoadInfoToFacultyCombobox(FacultyComboBox);
            _manager.LoadDefaultPhoto(PhotoPictureBox);
        }

        /// <summary>
        /// загрузка данных студента в текстбоксы и комбобоксы
        /// </summary>
        /// <param name="student">текущий студент</param>
        public void ChangeBoxes(Student student)
        {
            _student = student;

            SurnameTextBox.Text = _student.Surname;
            NameTextBox.Text = _student.Name;
            MiddlenameTextBox.Text = _student.MiddleName;
            CityTextBox.Text = _student.City;
            AddressTextBox.Text = _student.Street;
            TelefonTextBox.Text = _student.TelefonNumber;
            EmailTextBox.Text = _student.Email;

            FacultyComboBox.ValueMember = nameof(Faculty.ID);
            FacultyComboBox.SelectedValue = _student.FacultyID;

            SpecialityComboBox.ValueMember = nameof(Speciality.ID);
            SpecialityComboBox.SelectedValue = _student.SpecialityID;

            CourceComboBox.ValueMember = nameof(Cource.Number);
            CourceComboBox.SelectedValue = _student.Cource;

            GroupComboBox.ValueMember = nameof(Group.ID);
            GroupComboBox.SelectedValue = _student.GroupID;

            if (_student.Photo)
            {
                _manager.LoadFoto(_student, PhotoPictureBox);
                PhotoPictureBox.Name = _student.Guid.ToString();
            }
            else
            {
                _manager.LoadDefaultPhoto(PhotoPictureBox);
            }
        }

        private void SaveStudentCardButton_Click(object sender, EventArgs e)
        {
            if (_student == null)
            {
                _student = new Student
                {
                    Guid = Guid.NewGuid()
                };
                _dataStudent.Add(_student);
            }
            SaveCurrentStudent(_student);
            _manager.SaveData(_student);
            MessageBox.Show($"Данные {_student.Surname} сохранены");

            Close();
        }

        /// <summary>
        /// сохранение данных о конкретном студенте
        /// </summary>
        /// <param name="student">текущий студент</param>
        private void SaveCurrentStudent(Student student)
        {
            var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;
            var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
            var currentCource = (Cource)CourceComboBox.SelectedItem;
            var currentGroup = (Group)GroupComboBox.SelectedItem;

            student.Surname = SurnameTextBox.Text;
            student.Name = NameTextBox.Text;
            student.MiddleName = MiddlenameTextBox.Text;
            student.City = CityTextBox.Text;
            student.Street = AddressTextBox.Text;
            student.TelefonNumber = TelefonTextBox.Text;
            student.Email = EmailTextBox.Text;
            student.FacultyID = currentFaculty.ID;
            student.SpecialityID = currentSpeciality.ID;
            student.Cource = currentCource.Number;
            student.GroupID = currentGroup.ID;
            if (PhotoPictureBox.Name == student.Guid.ToString())
            {
                student.Photo = true;
                _manager.SavePhoto(student, PhotoPictureBox);
            }
            else
            {
                student.Photo = false;
            }
        }

        private void FotoPictureBox_Click(object sender, EventArgs e)
        {
            OpenPhoto(_student);
        }

        /// <summary>
        /// Открытие окна для поиска фото
        /// </summary>
        /// <param name="student">текущий студент</param>
        private void OpenPhoto(Student student)
        {
            if (FotoOpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            PhotoPictureBox.ImageLocation = FotoOpenFileDialog.FileName;
            PhotoPictureBox.Name = student.Guid.ToString();
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboBoxManager.LoadInfoToSpecialityComboBox(SpecialityComboBox, FacultyComboBox);
        }

        private void SpecialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboBoxManager.LoadInfoToCourceComboBox(CourceComboBox);
        }

        private void CourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboBoxManager.LoadInfoToGroupComboBox(GroupComboBox, SpecialityComboBox, CourceComboBox);
        }

        private void StudentCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                "Закрыть форму без сохранения?",
                "Закрыть",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    _studentTable.RefreshInfo();
                }
            }
        }
    }
}