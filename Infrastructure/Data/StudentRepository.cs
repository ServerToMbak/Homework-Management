using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Core.Entites;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly Homeworkcontext _context;
        public StudentRepository(Homeworkcontext context)
        {
            _context = context;
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(p=>p.Id==id);
        }

        public Task<IReadOnlyList<Student>> GetStudentsAsync()
        {
            throw new NotImplementedException();
        }
    }
}