using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCard
{
    public class StudentForTable
    {
        public string Surname { get; set; }
        public string Names { get; set; }
        public string MiddleName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public long TelefonNumber { get; set; }
        public string Email { get; set; }

        public string FacultyName { get; set; }
        public string SpecialityName { get; set; }
        public string GroupName { get; set; }
        public string Cource { get; set; }

        public List<StudentForTable> LoadInfoToTable()
        {
            var studentData = new SaveNLoadManager().LoadStudentData();
            var studentListForTable = new List<StudentForTable>();
            var curriculumInfo = new Curriculum().LoadCurruculumData();
            var facultyList = curriculumInfo.Faculties;
            var specialityList = curriculumInfo.Specialities;
            var groupList = curriculumInfo.Groups;
            foreach (Student student in studentData)
            {
                var studentForTable = new StudentForTable();
                studentListForTable.Add(studentForTable);
                studentForTable.Names = student.Names;
                studentForTable.MiddleName = student.MiddleName;
                studentForTable.Surname = student.Surname;
                studentForTable.City = student.City;
                studentForTable.Street = student.Street;
                studentForTable.TelefonNumber = student.TelefonNumber;
                studentForTable.Email = student.Email;

                for (var i = 0; i < facultyList.Count; i++)
                {
                    if (student.FacultyID == facultyList[i].ID)
                    {
                        studentForTable.FacultyName = facultyList[i].Name;
                    }
                }
                for (var k = 0; k < specialityList.Count; k++)
                {
                    if (student.SpecialityID == specialityList[k].ID)
                    {
                        studentForTable.SpecialityName = specialityList[k].Name;
                    }
                }

                for (var l = 0; l < groupList.Count; l++)
                {
                    if (student.GroupID == groupList[l].ID)
                    {
                        studentForTable.GroupName = groupList[l].Name;
                    }
                }
                studentForTable.Cource = student.Cource;
            }
            return studentListForTable;
        }
    }
}