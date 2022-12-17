namespace Core.Entites
{
    public class Student:BaseEntity
    {       
        public string Name { get; set; }
        public Homework Homework { get; set; }
        public int HomeworkId { get; set; }

    }
}