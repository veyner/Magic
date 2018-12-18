using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    public class Speciality
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Cource> Cources { get; set; }
    }
}