using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace StudentCard
{
    public class Curriculum
    {
        public List<Faculty> Faculties { get; set; }

        /*public void SaveCurriculumData()
        {
            var curriculumInfo = new Curriculum();
            curriculumInfo.Faculties = new List<Faculty>();
            curriculumInfo.Faculties.Add(new Faculty());
            var fac1 = curriculumInfo.Faculties[0];
            fac1.ID = 1;
            fac1.Name = "Психолого-педагогический";
            fac1.Specialities = new List<Speciality>();
            fac1.Specialities.Add(new Speciality());
            var spec1 = fac1.Specialities[0];
            spec1.Name = "Учитель информатики";
            spec1.ID = 1;
            spec1.Cources = new List<Cource>();
            spec1.Cources.Add(new Cource());
            var cource1 = spec1.Cources[0];
            cource1.Number = 1;
            cource1.Groups = new List<Group>();
            cource1.Groups.Add(new Group());
            var group1 = cource1.Groups[0];
            group1.ID = 1;
            group1.Name = "ПИ1";
            cource1.Groups.Add(new Group());
            var group2 = cource1.Groups[1];
            group2.ID = 2;
            group2.Name = "ПрИ1";

            var fullSavePath = Path.Combine(Properties.Settings.Default.PathToData, "CurriculumInfo.json");

            using (var writer = new StreamWriter(fullSavePath))
            {
                var json = JsonConvert.SerializeObject(curriculumInfo);
                writer.Write(json);
            }
        }*/

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