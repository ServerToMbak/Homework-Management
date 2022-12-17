using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.Data;
using Core.Entites;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class HomeworkContextSeed
    {
        public static async Task SeedAsync(Homeworkcontext context, ILoggerFactory loggerFactory)    
        {
            try
            {

            if(!context.Homeworks.Any())
            {
                 var homeworksData = File.ReadAllText("../Infrastructure/Data/SeedData/homeworks.json");

                 var homeworks = JsonSerializer.Deserialize<List<Homework>>(homeworksData);

                 foreach (var item in homeworks)
                 {
                    context.Add(item);
                 }
                await context.SaveChangesAsync();
            }
            if(!context.Teachers.Any())
            {
                 var teacherssData = File.ReadAllText("../Infrastructure/Data/SeedData/teachers.json");

                 var teachers = JsonSerializer.Deserialize<List<Teacher>>(teacherssData);

                 foreach (var item in teachers)
                 {
                    context.Add(item);
                 }
                await context.SaveChangesAsync();
            }
            if(!context.Students.Any())
            {
                 var studentsData = File.ReadAllText("../Infrastructure/Data/SeedData/students.json");

                 var students = JsonSerializer.Deserialize<List<Student>>(studentsData);

                 foreach (var item in students)
                 {
                    context.Add(item);
                 }
                await context.SaveChangesAsync();
            }
            }catch(Exception ex)
            {
                var logger = loggerFactory.CreateLogger<HomeworkContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}