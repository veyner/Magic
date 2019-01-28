using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace StudentCard
{
    public partial class TableManager : Form
    {
        public List<StudentForTable> FacultyFilter(Faculty currentFaculty)
        {
            var studentList = new StudentForTable().LoadInfoToTable();
            var currentStudentList = new List<StudentForTable>();

            currentStudentList.Clear();

            foreach (StudentForTable student in studentList)
            {
                if (student.FacultyName == currentFaculty.Name)
                {
                    currentStudentList.Add(student);
                }
            }
            return currentStudentList;
        }

        public List<StudentForTable> SpecialityFilter(Speciality currentSpeciality)
        {
            var studentList = new StudentForTable().LoadInfoToTable();
            var currentStudentList = new List<StudentForTable>();

            currentStudentList.Clear();

            foreach (StudentForTable student in studentList)
            {
                if (student.SpecialityName == currentSpeciality.Name)
                {
                    currentStudentList.Add(student);
                }
            }
            return currentStudentList;
        }

        public List<StudentForTable> GroupFilter(Group currentGroup)
        {
            var studentList = new StudentForTable().LoadInfoToTable();
            var currentStudentList = new List<StudentForTable>();

            currentStudentList.Clear();

            foreach (StudentForTable student in studentList)
            {
                if (student.GroupName == currentGroup.Name)
                {
                    currentStudentList.Add(student);
                }
            }
            return currentStudentList;
        }

        public List<StudentForTable> CourceFilter(Cource currentCource, Faculty currentFaculty, Speciality currentSpeciality, Group currentGroup)
        {
            var studentList = new StudentForTable().LoadInfoToTable();
            var currentStudentList = new List<StudentForTable>();
            if (studentList != null)
            {
                if (currentFaculty.ID == 0)
                {
                    foreach (StudentForTable student in studentList)
                    {
                        if (currentCource.Number == student.Cource)
                        {
                            currentStudentList.Add(student);
                        }
                    }
                }
                if (currentCource.Number == "Все")
                {
                    if (currentFaculty.ID == 0)
                    {
                        foreach (StudentForTable student in studentList)
                        {
                            currentStudentList.Add(student);
                        }
                    }
                    else
                    {
                        if (currentFaculty.ID != 0)
                        {
                            currentStudentList = new TableManager().FacultyFilter(currentFaculty);
                            if (currentSpeciality.ID != 0)
                            {
                                currentStudentList.Clear();

                                currentStudentList = new TableManager().SpecialityFilter(currentSpeciality);
                                if (currentGroup.ID != 0)
                                {
                                    currentStudentList.Clear();
                                    currentStudentList = new TableManager().GroupFilter(currentGroup);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (currentFaculty.ID != 0)
                    {
                        foreach (StudentForTable student in studentList)
                        {
                            if (currentFaculty.Name == student.FacultyName && currentCource.Number == student.Cource)
                            {
                                currentStudentList.Add(student);
                            }
                        }
                        if (currentSpeciality.ID != 0)
                        {
                            currentStudentList.Clear();

                            foreach (StudentForTable student in studentList)
                            {
                                if (currentSpeciality.Name == student.SpecialityName && currentCource.Number == student.Cource)
                                {
                                    currentStudentList.Add(student);
                                }
                            }
                            if (currentGroup.ID != 0)
                            {
                                currentStudentList.Clear();
                                foreach (StudentForTable student in studentList)
                                {
                                    if (currentGroup.Name == student.GroupName && currentCource.Number == student.Cource)
                                    {
                                        currentStudentList.Add(student);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return currentStudentList;
        }

        public void LoadFullInfo(DataGridView studentListDataGridView)
        {
            var studentListForTable = new StudentForTable().LoadInfoToTable();
            studentListDataGridView.DataSource = studentListForTable;
        }
    }
}