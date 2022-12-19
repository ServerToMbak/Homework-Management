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
    public class StudentsController : BaseApiController
    {
        public IStudentRepository _repo { get; }
        public StudentsController(IStudentRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> getStudent(int id)
        {
            return   Ok(await _repo.GetStudentByIdAsync(id));
        }
        
        
        [HttpGet("getAll")]
        public async Task<ActionResult<IReadOnlyList<Student>>> getStudents()
        {
            return   Ok(await _repo.GetStudentsAsync());
        }
    }
}