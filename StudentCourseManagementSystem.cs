namespace Mustakim
{
   public class StudentCourseManagementSystem
   {
      private List<Student> _students;
      public List<Course> _courses;
      private Random random = new Random();

      public StudentCourseManagementSystem()
      {
         try
         {
              _students = new List<Student>();
         _courses = new List<Course>();
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error initializing management system: {ex.Message}");
            
         }
       
      }
      public void AddStudent(string name, string department)
      {
         try
         {
            var student = new Student(name, department);
         _students.Add(student);
         Console.WriteLine($"Student added successfully. Matric: {student.Matric}"); 
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error adding student :{ex.Message}");
         
         }
        
      }

      public void AddCourse(string courseCode, string title, int unit)
      {
         try
         {
            var course = new Course(courseCode, title, unit);
            _courses.Add(course);
            Console.WriteLine($"Course added successfully.");
             
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error adding course: {ex.Message}");
            
         }
       
      }
      public void DisplayCourse()
      {
         try
         {
             Console.WriteLine("Available Courses:");
            foreach (var course in _courses)
            {
             
                  course.DisplayInfo();

               Console.WriteLine();

            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error dicplaying course: {ex.Message}");
         
         }
         
      }

      public void EnrollStudentInCourse(string matric, string courseCode)
      {
         try
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
         catch (Exception ex)
         {
            Console.WriteLine($"Error enrolling student in course : {ex.Message}");
         }
      }
           public void DisplayStudents()
    {
      try
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
      catch (Exception ex)
      {
         Console.WriteLine($"Error displaying student  : {ex.Message}");
         
      }
       
    }




   } 
} 