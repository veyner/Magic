using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic
{
    public class ComboBoxManager : Form
    {
        public ComboBoxManager()
        {
        }

        public void LoadInfoToFacultyCombobox(ComboBox facultyComboBox)
        {
            var curriculumInfo = new Curriculum().LoadCurruculumData();
            if (facultyComboBox.Name == "facultyComboBox")
            {
                facultyComboBox.DataSource = curriculumInfo.Faculties;
                facultyComboBox.DisplayMember = nameof(Faculty.Name);
                facultyComboBox.SelectedIndex = -1;
            }
        }

        public void LoadInfoToSpecialityComboBox(ComboBox specialityComboBox, ComboBox facultyComboBox)
        {
            if (facultyComboBox.SelectedIndex == -1)
            {
                specialityComboBox.SelectedIndex = -1;
            }
            else
            {
                var currentFaculty = (Faculty)facultyComboBox.SelectedItem;
                specialityComboBox.DataSource = currentFaculty.Specialities;
                specialityComboBox.DisplayMember = nameof(Speciality.Name);
                specialityComboBox.SelectedIndex = -1;
            }
        }

        public void LoadInfoToCourceComboBox(ComboBox courceComboBox, ComboBox specialityComboBox)
        {
            if (specialityComboBox.SelectedIndex == -1)
            {
                courceComboBox.SelectedIndex = -1;
            }
            else
            {
                var currentSpeciality = (Speciality)specialityComboBox.SelectedItem;
                courceComboBox.DataSource = currentSpeciality.Cources;
                courceComboBox.DisplayMember = nameof(Cource.Number);
                courceComboBox.SelectedIndex = -1;
            }
        }

        public void LoadInfoToGroupComboBox(ComboBox groupComboBox, ComboBox courceComboBox)
        {
            if (courceComboBox.SelectedIndex == -1)
            {
                groupComboBox.SelectedIndex = -1;
            }
            else
            {
                var currentCource = (Cource)courceComboBox.SelectedItem;
                groupComboBox.DataSource = currentCource.Groups;
                groupComboBox.DisplayMember = nameof(Group.Name);
                groupComboBox.SelectedIndex = -1;
            }
        }
    }
}