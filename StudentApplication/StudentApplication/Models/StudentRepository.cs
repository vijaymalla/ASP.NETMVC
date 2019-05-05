using System;
using System.Collections.Generic;

namespace StudentApplication.Models
{
    //Implements IStudentRepository
    public class StudentRepository : IStudentRepository
    {
        //So u need a private list of students
        private List<Student> _students;
        //Construct if students are not empty
        public StudentRepository()
        {
            if(_students == null)
            {
                InitStudents();
            }
        }

        public void InitStudents()
        {
            //Add students to the List 
            _students = new List<Student>
            {
                //Create multiple stduents with different data set
                new Student{Id=1,name="vijay",email="email1@gmail.com"},
            new Student { Id = 2, name = "malla", email = "email2@gmail.com" },
            new Student { Id = 3, name = "zack", email = "email3@gmail.com" },
            new Student { Id = 4, name = "andrew", email = "email4@gmail.com" }
            };
        }


        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}


//Refister this repository in the startup.cs for dependency injection