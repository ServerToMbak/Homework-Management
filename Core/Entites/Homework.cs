using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entites
{
    public class Homework:BaseEntity
    {
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}