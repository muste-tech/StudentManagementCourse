namespace Mustakim
{
   public class StudentCourseManagementSystem
   {
      private List<Student> _students;
      public List<Course> _courses;

      public StudentCourseManagementSystem()
      {
         _students = new List<Student>();
         _courses = new List<Course>();
      }
      public void AddStudent(string name, string department)
      {
         var student = new Student(name, department);
         _students.Add(student);
         Console.WriteLine($"Student added successfully. Matric: {student.Matric}");
      }

      public void AddCourse(string courseCode, string title, int unit)
      {
         var course = new Course(courseCode, title, unit);
         _courses.Add(course);
         Console.WriteLine($"Course added successfully.");
      }
      public void DisplayCourse(string title)
      {
          Console.WriteLine($"Courses available are: ");
           var course = _courses.Find(s=>s.Title==title);
        foreach (var cours in _courses)
         {
            Console.Write($"{cours}");
         }
      }

      public void EnrollStudentInCourse(string matric, string courseCode)
      {
         var student = _students.Find(s => s.Matric == matric);
         var course = _courses.Find(c => c.CourseCode == courseCode);


         if (student != null && course != null)
         {
            student.EnrolledCourses.Add(course);
            Console.WriteLine($"Student enrolled in course successfully.");
         }
         else
         {
            Console.WriteLine($"Student or course not found.");
         }
      }
           public void DisplayStudents()
    {
        foreach (var student in _students)
        {
            student.DisplayInfo();
            Console.WriteLine("Enrolled Courses:");
            foreach (var course in student.EnrolledCourses)
            {
                course.DisplayInfo();
            }
            Console.WriteLine();
        }
    }




   } 
}