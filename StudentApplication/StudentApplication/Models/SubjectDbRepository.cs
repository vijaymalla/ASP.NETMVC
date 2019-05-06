using System;
using System.Collections.Generic;

namespace StudentApplication.Models
{
    public class SubjectDbRepository : ISubjectRepository
    {
        public SubjectDbRepository()
        {

        }

        public IEnumerable<Subjects> GetAllSubjects()
        {
            throw new NotImplementedException();
        }
    }
}
