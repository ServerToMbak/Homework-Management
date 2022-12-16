using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entites
{
    public class Teacher:BaseEntity
    {
        public string Name { get; set; }
        public string Major { get; set; }
    }
}