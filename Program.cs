using System.Data.Common;

namespace Mustakim
{
    
    public class Program : StudentCourseManagementSystem

    {
       public List<Course> _courses;
        static void Main(string[] args)
        {
            var managementSystem = new StudentCourseManagementSystem();

            while (true)
            {
                Console.WriteLine("Student Course Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Enroll Student in Course");
                Console.WriteLine("4. Display All Students");
                Console.WriteLine("5. Exit");
                string tiTle;
                Console.Write("Choose an option: ");
                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.Write("User name");
                            string name1 = Console.ReadLine();
                            Console.Write("User Department");
                            string department1 = Console.ReadLine();
                            managementSystem.AddStudent(name1, department1);
                            break;
                        case 2:
                            Console.Write(" Course code: ");
                            string cCode = Console.ReadLine();
                            Console.Write(" Course Title: ");
                             tiTle = Console.ReadLine();
                            Console.Write(" Course unit: ");
                            int uNit = int.Parse(Console.ReadLine());

                            managementSystem.AddCourse(cCode, tiTle, uNit);
                            break;
                            string titLe = tiTle;
                        case 3:
                        
                        
                            managementSystem.DisplayCourse(titLe);
                            Console.Write("Input matric number: ");
                            string maTric = Console.ReadLine();
                            Console.Write("Enter course code: ");
                            string courseC = Console.ReadLine();

                           managementSystem.EnrollStudentInCourse(maTric,courseC);
                            break;
                        case 4:
                           managementSystem. DisplayStudents();
                            break;

                        case 5:
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


    }
}


