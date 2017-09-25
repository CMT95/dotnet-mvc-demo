using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mvc_demo.Models;
using mvc_demo.Models.Entities;

namespace mvc_demo.Controllers
{
    public class StudentController : Controller
    {

        //Model
        StudentDbContext db = new StudentDbContext();

        // readall in db
        public IActionResult Index()
        {
            IEnumerable<Student> students = db.Students;

            ViewBag.stud = db.Students;
            return View(students);
            
        }
       
        // search
        // søg på - firstName. Få udskrevet info om denne person.
        public IActionResult Search()
        {
            return View();
        }

        //create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student st)
        {
            if(ModelState.IsValid)
            {
            db.Students.Add(st);//new Student{FirstName="Cihat", LastName="Tokmak", Age=22});
            db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View();
        }
        
        //delete
        //update


         public IActionResult mvc(int id = 1000)
        {
            //model laget
            ViewBag.number = id;
            return View();
        }
    }
}