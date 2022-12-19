using System.Collections.Generic;

namespace Core.Entites
{
    public class Student:BaseEntity
    {       
        public string Name { get; set; }
        public List<Homework> Homeworks { get; set; }

    }
}