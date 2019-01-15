using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace StudentCard
{
    public class SaveNLoadManager
    {
        public void SaveData(Student student)
        {
            var fullSavePath = Path.Combine(Properties.Settings.Default.PathToStudentInfo, student.Surname + ".json");

            using (var writer = new StreamWriter(fullSavePath))
            {
                var json = JsonConvert.SerializeObject(student);
                writer.Write(json);
            }
        }

        public Student LoadData(string studentsData)
        {
            var fullDataPath = Path.Combine(Properties.Settings.Default.PathToStudentInfo, studentsData);
            using (var reader = new StreamReader(fullDataPath))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Student>(json);
            }
        }

        public List<Student> GetStudents(string PathToStudentInfo)
        {
            if (!Directory.Exists(PathToStudentInfo))
            {
                Directory.CreateDirectory(PathToStudentInfo);
            }

            var studentList = new List<Student>();
            var studentFiles = Directory.GetFiles(PathToStudentInfo);
            foreach (var student in studentFiles)
            {
                var i = LoadData(Path.GetFileName(student));
                studentList.Add(i);
            }
            return studentList;
        }

        public List<Student> LoadStudentData()
        {
            return GetStudents(Properties.Settings.Default.PathToStudentInfo);
        }
    }
}