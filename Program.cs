using System;
using System.Dynamic;
using System.Threading.Tasks.Dataflow;
namespace Mustakim
{
   public class Program

  {
    static List <Student> students =new List <Student>();
    static List <Course> courses =new List <Course>();
    static void Main()
    {
      //     int x = 5;
      //    int y = 10 ;
      //   int sum = x+y;
      //   int difference = x-y;
      //   int product =x*y;
      //  Console. WriteLine($"The sum of number {x} and {y} is: {sum}");
      //  Console.WriteLine();
      //  Console. WriteLine($"The difference between number {x} and {y} is: {difference}");
      //      Console.WriteLine();
      //   Console. WriteLine($"The product of number {x} and {y} is: {product}");

      //  Console.Write("Input first Name: ");
      //   string firstName = Console.ReadLine();
      //   Console.WriteLine();
      //     Console.Write("Input last Name: ");
      //     string lastName = Console.ReadLine();
      //     Console.WriteLine();
      // Console.WriteLine($"The name of the user is: {firstName} {lastName}");

      // Input the deposited amount

      //       var account = new BankAccount (1000);  
      //       while (true)
      // {


      //   Console.WriteLine("1, Deposit ");
      //   Console.WriteLine("2, Withdraw");
      //   Console.WriteLine("3, Account balance");
      //   Console.WriteLine("4, Exit");
      //   Console.WriteLine();
      //   Console.WriteLine("Choose from option 1-4");

      //   int option = int.Parse(Console.ReadLine());
      //   switch (option)                                        
      //   {
      //     case 1:
      //       Console.WriteLine("Input amount to deposit: ");
      //       decimal amount2 = decimal.Parse(Console.ReadLine());
      //       account.deposit(amount2);
      //       break;
      //     case 2:
      //       Console.WriteLine("Input amount to withdraw: ");
      //       decimal amount4 = decimal.Parse(Console.ReadLine());
      //       account.Withdraw(amount4);
      //       break;
      //     case 3:
      //       account.GetBalance();
      //       break;
      //     case 4:
      //       return;
      //     default:
      //       Console.WriteLine("Invalid option. Please choose again.");
      //       break;



      //   }




      //  }
      // Console.Write("Enter your name as an employee: ");
      // string name = Console.ReadLine();
      // Console.WriteLine("Choose post you want to do in the company from 1-3:");
      // Console.WriteLine("1, Gatekeeper:");
      //  Console.WriteLine("2, Driver:");
      //   Console.WriteLine("3, Accountant:");
      //  string post = Console.ReadLine();
      // decimal salary = 0;
      //  var employee = new Employee(name , salary, post);
      //  salary = employee.ChangeSalary(post);



      // Console.WriteLine(employee.ChangeSalary(post));
      // employee.ChangeSalary(post);
      // employee.DisplayInfo( name,salary);
      //         string name1= "";
      //         string brand1="";
      //         string model1="";
      //         bool Accelerate1=true;
      //         bool Start1=true;
      //         bool Stop1=true;
      //         int Wheel1=0;
      //         int Doors1=0;
      //         int Year1=0;
      //         int Seat1=0;





      //       Console.WriteLine("Input Name of car");
      //       name1=Console.ReadLine();


      //       Console.WriteLine("Input Brand of car");
      //       brand1=Console.ReadLine();

      //       Console.WriteLine("Input Model of car");
      //       model1=Console.ReadLine();

      //       Console.WriteLine("Input Accelerate the car");
      //       Console.WriteLine("Input true / false");
      //        Accelerate1=bool.Parse(Console.ReadLine());


      //       Console.WriteLine("Input Start the car");
      //       Console.WriteLine("Input true / false");
      //        Start1=bool.Parse(Console.ReadLine());

      //       Console.WriteLine("Input Stop the car");
      //       Console.WriteLine("Input true / false");
      //       Stop1=bool.Parse(Console.ReadLine());


      //       Console.WriteLine("Input Wheel of car");
      //       Wheel1=int.Parse(Console.ReadLine());

      //       Console.WriteLine("Input Year of car");
      //       Year1=int.Parse(Console.ReadLine());

      //       Console.WriteLine("Input Doors of car");
      //       Doors1=int.Parse(Console.ReadLine());


      //       Console.WriteLine("Input Seat of car");
      //       Seat1=int.Parse(Console.ReadLine());





      //  var car = new Car(brand1,model1,name1,Accelerate1,Stop1,Start1,Doors1,Wheel1,Year1,Seat1);

      //             car.DisplayInfo();

      // Console.WriteLine("Input the sound of the animal below");
      // Console.Write("Cat :");

      //  string sound=Console.ReadLine();
      //  Console.Write("Dog :");
      // string sound1=Console.ReadLine(); 
      //   var dog= new Dog(sound1); 

      //   var cat=new Cat (sound);
      //      cat.AnimalSound(sound);   
      //       dog.AnimalSound(sound1);


      // Student student = new Student(name, studentid);
      // var car = new Car();
      // car.StartEngine();
      // Console.WriteLine("Calculate the area and perimeter of a circle");
      // Console.Write("Input the radius of the circle: ");
      // double radius = double.Parse(Console.ReadLine());
      // var circle = new Circle(radius);
      // circle.Area();
      // circle.Perimeter();
        
   while (true)
   {
        Console.WriteLine("student course management system");
        Console.WriteLine("1. Add student");
        Console.WriteLine("2. Add course");
        Console.WriteLine("3. Enroll student in course");
        Console.WriteLine("4. Display All student ");
        Console.WriteLine("5. Display All course");
        Console.WriteLine("6. Exit");

        Console.Write("Chooose an option ");
        
         try
       
            {
                int option= int.Parse(Console.ReadLine());
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
        string studentid = Console.ReadLine();
        Console.Write("Enter student department: ");
        string department = Console.ReadLine();
        try
        {
             if (students.Exists(s => s.StudentID == studentid))
                {
               throw new Exception("Student with this ID already exist");
                }
                Student student = new Student(name ,studentid, department);
                students.Add(student);
                Console.WriteLine("student added successfully.");
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
            int unit= int.Parse(Console.ReadLine());
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
       catch(Exception ex)
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
           Student student = students.Find(s => s.StudentID == studentId); 
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
