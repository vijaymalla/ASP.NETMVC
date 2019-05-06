using System;
using System.Collections.Generic;

namespace StudentApplication.Models
{
    public interface ISubjectRepository
    {
        IEnumerable<Subjects> GetAllSubjects();
    }
}
