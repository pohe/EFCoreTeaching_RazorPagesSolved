using EFCoreTeaching_RazorPages.Models;
using EFCoreTeaching_RazorPages.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTeaching_RazorPages.Services.EFServices
{
    public class EFCourseService:ICourseService
    {
        RegistrationDBContext context;
        public EFCourseService(RegistrationDBContext service)
        {
            context = service;
        }

        public IEnumerable<Course> getCourses()
        {
            return context.Courses.Include(c=>c.Enrollments);
        }

        public Course GetCourse(int cid)
        {
            var course = context.Courses.Include(c => c.Enrollments).ThenInclude(s => s.Student).AsNoTracking()
                .FirstOrDefault(c => c.CourseId == cid);
            return course;
        }

        public void AddCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }
    }
}
