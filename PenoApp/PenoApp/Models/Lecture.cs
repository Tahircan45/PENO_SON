using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenoApp.Models
{
    public class Lecture
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public ICollection<LecAndStudent> LecAndStudents{ set; get; }
    }
}
