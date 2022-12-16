using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entites;

namespace Core.Interfaces
{
    public interface IStudentRepository
    {
         Task<Student> GetStudentByIdAsync(int id);
         Task<IReadOnlyList<Student>> GetStudentsAsync();
    }
}