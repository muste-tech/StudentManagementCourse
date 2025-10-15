namespace Mustakim
{
  public  class Program
   
{
   
  static List<Student> students = new List<Student>();
    static List<Course> courses = new List<Course>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Student Course Management System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("3. Enroll Student in Course");
            Console.WriteLine("4. Display All Students");
            Console.WriteLine("5. Display All Courses");
            Console.WriteLine("6. Exit");

            Console.Write("Choose an option: ");
            try
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        AddCourse();
                        break;
                    case 3:
                        EnrollStudentInCourse();
                        break;
                    case 4:
                        DisplayAllStudents();
                        break;
                    case 5:
                        DisplayAllCourses();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter student ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter student department: ");
        string department = Console.ReadLine();

        try
        {
            if (students.Exists(s => s.Id == id))
            {
                throw new Exception("Student with this ID already exists.");
            }
            Student student = new Student(name, id, department);
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void AddCourse()
    {
        Console.Write("Enter course code: ");
        string courseCode = Console.ReadLine();
        Console.Write("Enter course title: ");
        string title = Console.ReadLine();
        Console.Write("Enter course unit: ");
        try
        {
            int unit = Convert.ToInt32(Console.ReadLine());
            if (courses.Exists(c => c.CourseCode == courseCode))
            {
                throw new Exception("Course with this code already exists.");
            }
            Course course = new Course(courseCode, title, unit);
            courses.Add(course);
            Console.WriteLine("Course added successfully.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number for the course unit.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void EnrollStudentInCourse()
    {
        Console.Write("Enter student ID: ");
        string studentId = Console.ReadLine();
        try
        {
            Student student = students.Find(s => s.Id == studentId);
            if (student == null)
            {
                throw new Exception("Student not found.");
            }
            Console.Write("Enter course code: ");
            string courseCode = Console.ReadLine();
            Course course = courses.Find(c => c.CourseCode == courseCode);
            if (course == null)
            {
                throw new Exception("Course not found.");
            }
            student.EnrollCourse(course);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
     static void DisplayAllStudents()
    {
        foreach (var student in students)
        {
            student.DisplayInfo();
            Console.WriteLine();
        }
    }

    static void DisplayAllCourses()
    {
        foreach (var course in courses)
        {
            course.DisplayInfo();
        }
    }
}




}
