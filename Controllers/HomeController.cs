using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var context = new TrainingContext();

            var student = new Student()
            {
                Name = "Jalaluddin",
                BirthDate = DateTime.Now,
                StudentCourses = new List<StudentCourse>()
            };

            var course = new Course()
            {
                Name = "Laravel",
                Price = 20000,
                Topics =  new List<CourseTopic>()
            };

            course.Topics.Add(new CourseTopic()
            {
                Name = "Intro",
                Description = "Getting started"
            });
        

            student.StudentCourses.Add(new StudentCourse()
            {
                Course = course
            });

            context.Students.Add(student);
            context.SaveChanges();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
