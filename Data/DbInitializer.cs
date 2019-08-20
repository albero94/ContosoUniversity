using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ContosoUniversityContext context)
        {
            context.Database.EnsureCreated();

            if (context.Student.Any()) return;

            var students = new Student[]
            {
                new Student{FirstName = "Alvaro", LastName="Albero", EnrollmentDate = DateTime.Parse("2005-09-01")},
                new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students) context.Student.Add(s);
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{ID=1050,Title="Chemistry",Credits=3},
            new Course{ID=4022,Title="Microeconomics",Credits=3},
            new Course{ID=4041,Title="Macroeconomics",Credits=3},
            new Course{ID=1045,Title="Calculus",Credits=4},
            new Course{ID=3141,Title="Trigonometry",Credits=4},
            new Course{ID=2021,Title="Composition",Credits=3},
            new Course{ID=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Course.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentId=1,CourseId=1050,Grade=Grade.A},
            new Enrollment{StudentId=1,CourseId=4022,Grade=Grade.C},
            new Enrollment{StudentId=1,CourseId=4041,Grade=Grade.B},
            new Enrollment{StudentId=2,CourseId=1045,Grade=Grade.B},
            new Enrollment{StudentId=2,CourseId=3141,Grade=Grade.F},
            new Enrollment{StudentId=2,CourseId=2021,Grade=Grade.F},
            new Enrollment{StudentId=3,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=4022,Grade=Grade.F},
            new Enrollment{StudentId=5,CourseId=4041,Grade=Grade.C},
            new Enrollment{StudentId=6,CourseId=1045},
            new Enrollment{StudentId=7,CourseId=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollment.Add(e);
            }
            context.SaveChanges();
        }
    }
}
