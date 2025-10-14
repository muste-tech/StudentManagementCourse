namespace Mustakim
{
    public class Student : Person
    {
        public string StudentID { get; set; }
        public string Department { get; set; }
        public List<Course> EnrolledCourse { get; set; }
        public Student(string name, string studentid, string department)
        : base(name)
        {
            StudentID = studentid;
            Department = department;
            EnrolledCourse = new List<Course>();
        }
        public void EnrollCourse(Course course)
        {
             try
             {
                if(!EnrolledCourse.Contains(course))-
            {
                EnrolledCourse.Add(course);
            }
             }
             catch (Exception ex)
             {
                
               Console.WriteLine(ex.Message);
             } 
     
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Student info :" + Name, StudentID, Department);
            Console.WriteLine();
            Console.WriteLine("Enrolled course");
            foreach (var course in EnrolledCourse)
            {
                Console.WriteLine($"{course.CourseCode}-{course.Title}");
              }
        }
    }
}