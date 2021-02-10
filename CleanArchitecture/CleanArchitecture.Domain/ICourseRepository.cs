using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
