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
    }
}