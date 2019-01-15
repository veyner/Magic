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
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public long TelefonNumber { get; set; }
        public string Email { get; set; }

        public string FacultyName { get; set; }
        public string SpecialityName { get; set; }
        public string GroupName { get; set; }
        public string CourceNumber { get; set; }

        public List<StudentForTable> LoadInfoToTable()
        {
            var studentData = new SaveNLoadManager().LoadStudentData();
            var studentListForTable = new List<StudentForTable>();
            foreach (Student student in studentData)
            {
                var studentForTable = new StudentForTable();
                studentListForTable.Add(studentForTable);
                studentForTable.Name = student.Name;
                studentForTable.MiddleName = student.MiddleName;
                studentForTable.Surname = student.Surname;
                studentForTable.City = student.City;
                studentForTable.Street = student.Street;
                studentForTable.TelefonNumber = student.TelefonNumber;
                studentForTable.Email = student.Email;
            }

            var curriculumInfo = new Curriculum().LoadCurruculumData();
            var facultyList = curriculumInfo.Faculties;
            for (var i = 0; i < studentData.Count; i++)
            {
                for (var k = 0; k < facultyList.Count; k++)
                {
                    if (studentData[i].FacultyID == facultyList[k].ID)
                    {
                        studentListForTable[i].FacultyName = facultyList[k].Name;
                        var specialityList = facultyList[k].Specialities;

                        for (var l = 0; l < specialityList.Count; l++)
                        {
                            if (studentData[i].SpecialityID == specialityList[l].ID)
                            {
                                studentListForTable[i].SpecialityName = specialityList[l].Name;
                                var courceList = specialityList[l].Cources;

                                for (var m = 0; m < courceList.Count; m++)
                                {
                                    if (studentData[i].CourceID == courceList[m].ID)
                                    {
                                        studentListForTable[i].CourceNumber = courceList[m].Number;
                                        var groupList = courceList[m].Groups;

                                        for (var n = 0; n < groupList.Count; n++)
                                        {
                                            if (studentData[i].GroupID == groupList[n].ID)
                                            {
                                                studentListForTable[i].GroupName = groupList[n].Name;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return studentListForTable;
        }
    }
}