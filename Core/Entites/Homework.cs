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
        public int StıdentId { get; set; }
    }
}