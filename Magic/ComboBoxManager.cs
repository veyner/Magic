using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCard
{
    public class ComboBoxManager : Form
    {
        public ComboBoxManager()
        {
        }

        public void LoadInfoToFacultyCombobox(ComboBox facultyComboBox)
        {
            var curriculumInfo = new Curriculum().LoadCurruculumData();
            if (facultyComboBox.Name == "FacultyComboBox")
            {
                facultyComboBox.DataSource = curriculumInfo.Faculties;
                facultyComboBox.DisplayMember = nameof(Faculty.Name);
            }
        }

        public void LoadInfoToSpecialityComboBox(ComboBox specialityComboBox, ComboBox facultyComboBox)
        {
            var curriculumInfo = new Curriculum().LoadCurruculumData();
            var specialityList = curriculumInfo.Specialities;
            var currentFaculty = (Faculty)facultyComboBox.SelectedItem;

            var specialitiesForCurrentFaculty = new List<Speciality>();
            specialitiesForCurrentFaculty.Add(specialityList[0]);
            foreach (Speciality speciality in specialityList)
            {
                if (speciality.FacultyID == currentFaculty.ID)
                {
                    specialitiesForCurrentFaculty.Add(speciality);
                }
            }
            specialityComboBox.DataSource = specialitiesForCurrentFaculty;
            specialityComboBox.DisplayMember = nameof(Speciality.Name);
        }

        public void LoadInfoToCourceComboBox(ComboBox courceComboBox)
        {
            var cources = new List<Cource>();
            var emptyCource = new Cource();
            emptyCource.Number = "Все";
            cources.Add(emptyCource);
            for (var i = 0; i < 5; i++)
            {
                var cource = new Cource();
                cource.Number = (i + 1).ToString();
                cources.Add(cource);
            }
            courceComboBox.DataSource = cources;
            courceComboBox.DisplayMember = nameof(Cource.Number);
        }

        public void LoadInfoToGroupComboBox(ComboBox groupComboBox, ComboBox specialityComboBox)
        {
            var curriculumInfo = new Curriculum().LoadCurruculumData();
            var groupList = curriculumInfo.Groups;
            var currentSpeciality = (Speciality)specialityComboBox.SelectedItem;

            var groupsForCurrentSpeciality = new List<Group>();
            groupsForCurrentSpeciality.Add(groupList[0]);
            foreach (Group group in groupList)
            {
                if (group.SpecialityID == currentSpeciality.ID)
                {
                    groupsForCurrentSpeciality.Add(group);
                }
            }
            groupComboBox.DataSource = groupsForCurrentSpeciality;
            groupComboBox.DisplayMember = nameof(Group.Name);
        }
    }
}