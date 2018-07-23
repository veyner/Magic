using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Magic
{
    public class Curriculum
    {
        public List<Faculty> Faculties { get; set; }
        public List<Group> Groups { get; set; }
        /*
        public string Speciality { get; set; }
        public string Cource { get; set; }

        */

        /*public void SaveData()
        {
            var curriculumInfo = new Curriculum();
            var faculties = new List<Faculty>();
            faculties.Add(new Faculty());
            faculties[0].ID = 1;
            faculties[0].Name = "Psix-ped";
            faculties.Add(new Faculty());
            faculties[1] = new Faculty();
            faculties[1].ID = 2;
            faculties[1].Name = "Ist-Fil";
            var groups = new List<Group>();
            groups.Add(new Group());
            groups[0].ID = 1;
            groups[0].Name = "PM2P";
            groups.Add(new Group());
            groups[1].ID = 2;
            groups[1].Name = "PM2K";
            curriculumInfo.Faculties = faculties;
            curriculumInfo.Groups = groups;

            var fullSavePath = Path.Combine(Properties.Settings.Default.PathToData, "CurriculumInfo.json");

            using (var writer = new StreamWriter(fullSavePath))
            {
                var json = JsonConvert.SerializeObject(curriculumInfo);
                writer.Write(json);
            }
        }
        */

        public Curriculum LoadCurruculumData()
        {
            var fullDataPath = Path.Combine(Properties.Settings.Default.PathToData, "CurriculumInfo.json");
            using (var reader = new StreamReader(fullDataPath))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Curriculum>(json);
            }
        }
    }
}