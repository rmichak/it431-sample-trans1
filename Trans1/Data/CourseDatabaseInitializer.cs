using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Trans1.Models;

namespace Trans1.Data
{
    public class Trans1DBInitializer : DropCreateDatabaseAlways<Trans1Context>
    {
        protected override void Seed(Trans1Context context)
        {

            IList<Course> defaultCourses = new List<Course>();

            defaultCourses.Add(new Course() { Name = "Course 1", Credits=3, Term="Spring", Grade="A" });
            defaultCourses.Add(new Course() { Name = "Course 2", Credits = 3, Term = "Spring", Grade = "A" });
            defaultCourses.Add(new Course() { Name = "Course 3", Credits = 3, Term = "Spring", Grade = "A" });
            defaultCourses.Add(new Course() { Name = "Course 4", Credits = 3, Term = "Spring", Grade = "A" });
            defaultCourses.Add(new Course() { Name = "Course 5", Credits = 3, Term = "Spring", Grade = "A" });

            context.Courses.AddRange(defaultCourses);

            base.Seed(context);
        }
    }
}