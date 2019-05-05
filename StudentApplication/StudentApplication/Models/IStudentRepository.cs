using System;
using System.Collections.Generic;

namespace StudentApplication.Models
{
    public interface IStudentRepository
    {
        //Get all students from data 
        IEnumerable<Student> GetAllStudents();
        Student GetById(int Id);
    }
}

//Implement this interface in other class (model)