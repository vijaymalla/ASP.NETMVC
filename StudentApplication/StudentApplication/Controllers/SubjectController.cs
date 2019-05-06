using System;
using Microsoft.AspNetCore.Mvc;
using StudentApplication.Models;

namespace StudentApplication.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {

        private readonly AppDbContext _db;
        public SubjectController(AppDbContext db)
        {
            _db = db;
        }
    }
}
