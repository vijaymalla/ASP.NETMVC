using System;
using System.Collections.Generic;

namespace StudentApplication.Models
{
    public class StudentDBRepository : IStudentRepository
    {

        private readonly AppDbContext _appDbContext;

        public StudentDBRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _appDbContext.Students;
        }

        public Student GetById(int Id)
        {
            return _appDbContext.Students.Find(Id == Id);
        }
    }
}
