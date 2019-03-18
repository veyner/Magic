using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCard
{
    public class ComboBoxManager
    {
        private Curriculum curriculumInfo;

        public ComboBoxManager()
        {
            curriculumInfo = new SaveNLoadManager().LoadCurruculumData();
        }

        public void LoadInfoToFacultyCombobox(ComboBox facultyComboBox)
        {
            if (facultyComboBox.Name == "FacultyComboBox")
            {
                facultyComboBox.DataSource = curriculumInfo.Faculties;
                facultyComboBox.DisplayMember = nameof(Faculty.Name);
            }
        }

        public void LoadInfoToSpecialityComboBox(ComboBox specialityComboBox, ComboBox facultyComboBox)
        {
            var specialityList = curriculumInfo.Specialities;
            var currentFaculty = (Faculty)facultyComboBox.SelectedItem;

            var specialitiesForCurrentFaculty = new List<Speciality>
            {
                specialityList[0]
            };
            foreach (Speciality speciality in specialityList)
            {
                if (speciality.FacultyID == currentFaculty.ID & currentFaculty.ID != 0)
                {
                    specialitiesForCurrentFaculty.Add(speciality);
                }
            }
            specialityComboBox.DataSource = specialitiesForCurrentFaculty;
            specialityComboBox.DisplayMember = nameof(Speciality.Name);
        }

        public void LoadInfoToCourceComboBox(ComboBox courceComboBox)
        {
            var cources = CreateCourceList();
            courceComboBox.DataSource = cources;
            courceComboBox.DisplayMember = nameof(Cource.Number);
        }

        public List<Cource> CreateCourceList()
        {
            var cources = new List<Cource>();
            var emptyCource = new Cource
            {
                Number = "Все"
            };
            cources.Add(emptyCource);
            for (var i = 0; i < 5; i++)
            {
                var cource = new Cource
                {
                    Number = (i + 1).ToString()
                };
                cources.Add(cource);
            }
            return cources;
        }

        public void LoadInfoToGroupComboBox(ComboBox groupComboBox, ComboBox specialityComboBox, ComboBox courceComboBox)
        {
            var groupList = curriculumInfo.Groups;
            var currentSpeciality = (Speciality)specialityComboBox.SelectedItem;
            var currentCource = (Cource)courceComboBox.SelectedItem;

            var groupsForCurrentSpeciality = new List<Group>
            {
                groupList[0]
            };
            if (currentCource.Number != "Все")
            {
                foreach (Group group in groupList)
                {
                    if (group.SpecialityID == currentSpeciality.ID & group.Cource == currentCource.Number)
                    {
                        groupsForCurrentSpeciality.Add(group);
                    }
                }
            }

            groupComboBox.DataSource = groupsForCurrentSpeciality;
            groupComboBox.DisplayMember = nameof(Group.Name);
        }
    }
}