using EFCoreTeaching_RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;

namespace EFCoreTeaching_RazorPages.Services.Interface
{
   public  interface ICourseService
   {
       IEnumerable<Course> getCourses();
       Course GetCourse(int cid);
       void AddCourse(Course course);

    }
}
