using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Entites;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        public IStudentRepository _repo { get; }
        public StudentController(IStudentRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<Student>> getStudent(int id)
        {
            return   Ok(await _repo.GetStudentByIdAsync(id));
        }
        
        
        [HttpGet("students")]
        public async Task<ActionResult<IReadOnlyList<Student>>> getStudents()
        {
            return   Ok(await _repo.GetStudentsAsync());
        }
    }
}