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

        private void facultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToSpecialityComboBox(SpecialityComboBox, FacultyComboBox);
        }

        private void specialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToGroupComboBox(GroupComboBox, SpecialityComboBox);
        }

        private void saveStudentCardButton_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;
            var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
            var currentCource = (Cource)CourceComboBox.SelectedItem;
            var currentGroup = (Group)GroupComboBox.SelectedItem;

            student.Guid = Guid.NewGuid();
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
            FotoPictureBox.Image.Save(Path.Combine(Magic.Properties.Settings.Default.PathToFoto, student.Guid.ToString() + ".jpg"));
            new SaveNLoadManager().SaveData(student);
            MessageBox.Show($"Данные {student.Surname} сохранены");
            Close();
        }

        private void showStudentListbutton_Click(object sender, EventArgs e)
        {
            new StudentTable().Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            AllowChanges();
        }

        private void StudentCard_Load(object sender, EventArgs e)
        {
        }

        public void LockChanges()
        {
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

        public void AllowChanges()
        {
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