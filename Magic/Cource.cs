using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCard
{
    public class Cource
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public List<Group> Groups { get; set; }
    }
}