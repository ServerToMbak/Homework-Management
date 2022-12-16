using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entites
{
    public class Student:BaseEntity
    {       
        public string Name { get; set; }
        public Homework Homework { get; set; }

    }
}