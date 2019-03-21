using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace StudentCard
{
    public class SaveNLoadManager
    {
        public void SaveData(Student student)
        {
            var fullSavePath = Path.Combine(Magic.Properties.Settings.Default.PathToStudentInfo, student.Guid.ToString() + ".json");

            using (var writer = new StreamWriter(fullSavePath))
            {
                var json = JsonConvert.SerializeObject(student);
                writer.Write(json);
            }
        }

        public void DeleteData(Student student)
        {
            var fullPathToStudent = Path.Combine(Magic.Properties.Settings.Default.PathToStudentInfo, student.Guid.ToString() + ".json");
            if (student.Photo)
            {
                var fullPathToFoto = Path.Combine(Magic.Properties.Settings.Default.PathToFoto, student.Guid.ToString() + ".jpg");
                File.Delete(fullPathToFoto);
            }
            File.Delete(fullPathToStudent);
        }

        private Student LoadData(string studentsData)
        {
            var fullDataPath = Path.Combine(Magic.Properties.Settings.Default.PathToStudentInfo, studentsData);

            using (var reader = new StreamReader(fullDataPath))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Student>(json);
            }
        }

        private List<Student> GetStudents(string PathToStudentInfo)
        {
            if (!Directory.Exists(PathToStudentInfo))
            {
                Directory.CreateDirectory(PathToStudentInfo);
            }

            var studentList = new List<Student>();
            foreach (var student in Directory.GetFiles(PathToStudentInfo))
            {
                var i = LoadData(Path.GetFileName(student));
                studentList.Add(i);
            }
            return studentList;
        }

        public List<Student> LoadStudentData()
        {
            return GetStudents(Magic.Properties.Settings.Default.PathToStudentInfo);
        }

        public Curriculum LoadCurruculumData()
        {
            var fullDataPath = Path.Combine(Magic.Properties.Settings.Default.PathToData, "CurriculumInfo.json");
            using (var reader = new StreamReader(fullDataPath))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Curriculum>(json); ;
            }
        }

        public void LoadFoto(Student student, PictureBox pictureBox)
        {
            pictureBox.ImageLocation = Path.Combine(Magic.Properties.Settings.Default.PathToFoto, student.Guid.ToString() + ".jpg");
        }

        public void LoadDefaultPhoto(PictureBox pictureBox)
        {
            pictureBox.ImageLocation = Path.Combine(Magic.Properties.Settings.Default.PathToFoto, "DefaultPhoto.jpg");
            pictureBox.Name = "Default";
        }

        public void SavePhoto(Student student, PictureBox pictureBox)
        {
            pictureBox.Image.Save(Path.Combine(Magic.Properties.Settings.Default.PathToFoto, student.Guid.ToString() + ".jpg"));
        }
    }
}