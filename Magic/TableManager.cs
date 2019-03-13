using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace StudentCard
{
    public partial class TableManager
    {
        //    private Curriculum curriculumInfo;

        //    public TableManager()
        //    {
        //        curriculumInfo = new SaveNLoadManager().LoadCurruculumData();
        //    }

        //    public List<StudentForTable> LoadInfoToTable()
        //    {
        //        var studentData = new SaveNLoadManager().LoadStudentData();
        //        var studentListForTable = new List<StudentForTable>();
        //        var facultyList = curriculumInfo.Faculties;
        //        var specialityList = curriculumInfo.Specialities;
        //        var groupList = curriculumInfo.Groups;

        //        List<Student> students1 = new List<Student>();

        //        //foreach (var student in studentData)
        //        //{
        //        //    if (student.Cource == "1")
        //        //    {
        //        //        students1.Add(student);
        //        //    }
        //        //}

        //        //var students = studentData.Where(student => student.Cource == "1");

        //        foreach (Student student in studentData)
        //        {
        //            var studentForTable = new StudentForTable();
        //            //{
        //            //    Names = student.Names,
        //            //    Cource =
        //            //};
        //            studentForTable.Names = student.Names;
        //            studentForTable.MiddleName = student.MiddleName;
        //            studentForTable.Surname = student.Surname;
        //            studentForTable.City = student.City;
        //            studentForTable.Street = student.Street;
        //            studentForTable.TelefonNumber = student.TelefonNumber;
        //            studentForTable.Email = student.Email;

        //            studentListForTable.Add(studentForTable);

        //            for (var i = 0; i < facultyList.Count; i++)
        //            {
        //                if (student.FacultyID == facultyList[i].ID)
        //                {
        //                    studentForTable.FacultyName = facultyList[i].Name;
        //                }
        //            }
        //            for (var k = 0; k < specialityList.Count; k++)
        //            {
        //                if (student.SpecialityID == specialityList[k].ID)
        //                {
        //                    studentForTable.SpecialityName = specialityList[k].Name;
        //                }
        //            }

        //            for (var l = 0; l < groupList.Count; l++)
        //            {
        //                if (student.GroupID == groupList[l].ID)
        //                {
        //                    studentForTable.GroupName = groupList[l].Name;
        //                }
        //            }
        //            studentForTable.Cource = student.Cource;
        //        }
        //        return studentListForTable;
        //    }

        //    public List<StudentForTable> FacultyFilter(Faculty currentFaculty)
        //    {
        //        var studentList = LoadInfoToTable();
        //        var currentStudentList = new List<StudentForTable>();

        //        currentStudentList.Clear();

        //        foreach (StudentForTable student in studentList)
        //        {
        //            if (student.FacultyName == currentFaculty.Name)
        //            {
        //                currentStudentList.Add(student);
        //            }
        //        }
        //        return currentStudentList;
        //    }

        //    public List<StudentForTable> SpecialityFilter(Speciality currentSpeciality)
        //    {
        //        var studentList = LoadInfoToTable();
        //        var currentStudentList = new List<StudentForTable>();

        //        currentStudentList.Clear();

        //        foreach (StudentForTable student in studentList)
        //        {
        //            if (student.SpecialityName == currentSpeciality.Name)
        //            {
        //                currentStudentList.Add(student);
        //            }
        //        }
        //        return currentStudentList;
        //    }

        //    public List<StudentForTable> GroupFilter(Group currentGroup)
        //    {
        //        var studentList = LoadInfoToTable();
        //        var currentStudentList = new List<StudentForTable>();

        //        currentStudentList.Clear();

        //        foreach (StudentForTable student in studentList)
        //        {
        //            if (student.GroupName == currentGroup.Name)
        //            {
        //                currentStudentList.Add(student);
        //            }
        //        }
        //        return currentStudentList;
        //    }

        //    public List<StudentForTable> CourceFilter(Cource currentCource, Faculty currentFaculty, Speciality currentSpeciality, Group currentGroup)
        //    {
        //        var studentList = LoadInfoToTable();
        //        var currentStudentList = new List<StudentForTable>();
        //        if (studentList != null)
        //        {
        //            if (currentFaculty.ID == 0)
        //            {
        //                foreach (StudentForTable student in studentList)
        //                {
        //                    if (currentCource.Number == student.Cource)
        //                    {
        //                        currentStudentList.Add(student);
        //                    }
        //                }
        //            }
        //            if (currentCource.Number == "Все")
        //            {
        //                if (currentFaculty.ID == 0)
        //                {
        //                    foreach (StudentForTable student in studentList)
        //                    {
        //                        currentStudentList.Add(student);
        //                    }
        //                }
        //                else
        //                {
        //                    if (currentFaculty.ID != 0)
        //                    {
        //                        currentStudentList = new TableManager().FacultyFilter(currentFaculty);
        //                        if (currentSpeciality.ID != 0)
        //                        {
        //                            currentStudentList.Clear();

        //                            currentStudentList = new TableManager().SpecialityFilter(currentSpeciality);
        //                            if (currentGroup.ID != 0)
        //                            {
        //                                currentStudentList.Clear();
        //                                currentStudentList = new TableManager().GroupFilter(currentGroup);
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                if (currentFaculty.ID != 0)
        //                {
        //                    foreach (StudentForTable student in studentList)
        //                    {
        //                        if (currentFaculty.Name == student.FacultyName && currentCource.Number == student.Cource)
        //                        {
        //                            currentStudentList.Add(student);
        //                        }
        //                    }
        //                    if (currentSpeciality.ID != 0)
        //                    {
        //                        currentStudentList.Clear();

        //                        foreach (StudentForTable student in studentList)
        //                        {
        //                            if (currentSpeciality.Name == student.SpecialityName && currentCource.Number == student.Cource)
        //                            {
        //                                currentStudentList.Add(student);
        //                            }
        //                        }
        //                        if (currentGroup.ID != 0)
        //                        {
        //                            currentStudentList.Clear();
        //                            foreach (StudentForTable student in studentList)
        //                            {
        //                                if (currentGroup.Name == student.GroupName && currentCource.Number == student.Cource)
        //                                {
        //                                    currentStudentList.Add(student);
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        return currentStudentList;
        //    }

        //    public void LoadFullInfo(DataGridView studentListDataGridView)
        //    {
        //        var studentListForTable = LoadInfoToTable();
        //        studentListDataGridView.DataSource = studentListForTable;
        //    }
    }
}