using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentApplication.Models;

namespace StudentApplication.Controllers
{
    public class HomeController : Controller
    {
        //Initilize a private field of IStudentRepository type
        private readonly IStudentRepository _studentRepository;


        //Constructor using IStudentRepository dependency defined in startup.cs
        //We are getting dependy from services from startup.cs class and assigning them to the private readonly _studentRepository 
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        //Need to connect to the view file which is in Views folder 
        public IActionResult Index()
        {

            return View();
        }

        //Need to connect to the view file which is in Views folder 
        public IActionResult AddStudent()
        {
            //This is a title of the section, We can customize the message
            ViewBag.AddStudent = "Add Student";
            ViewBag.List = "Students List";

            //Get all Students from the Student repository and return it to the view to display
            var students = _studentRepository.GetAllStudents().OrderBy(p => p.Id);
            return View(students);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
