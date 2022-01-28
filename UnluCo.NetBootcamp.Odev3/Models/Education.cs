using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.NetBootcamp.Odev3.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Educator> Educators { get; set; }
        public virtual List<Assistant> Assistants { get; set; }
    }
}
