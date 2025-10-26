using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace Mustakim
{
    
    public class Program

    {
        static void Main(string[] args)
        {
            var managementSystem = new StudentCourseManagementSystem();
            Console.WriteLine(" Welcome to  the Student Course Management System!");
            Console.WriteLine("What would you like to do today");
            while (true)
            {
                try
                {


                    Console.WriteLine("1. Manage Student");
                    Console.WriteLine("2. Manage Course");
                    Console.WriteLine("3. Enroll Student in Course");
                    Console.WriteLine("4. Display Information");
                    Console.WriteLine("5. Exit");
                    string tiTle;
                    Console.Write("Choose an option from (1-5): ");

                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:

                            ManageStudents(managementSystem);
                            break;
                        case 2:
                            ManageCourses(managementSystem);
                            break;

                        case 3:
                            EnrollStudentsInCourses(managementSystem);

                            break;
                        case 4:
                            DisplayInformation(managementSystem);
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please choose a valid option.");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occured : {ex.Message}");
                }

            }

            static void ManageStudents(StudentCourseManagementSystem managementSystem)
            {
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("1, Add student");
                        Console.WriteLine("2, Go Back");
                        Console.Write("Enter your choice(1-2): ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter student name:");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter student department:");
                                string department = Console.ReadLine();
                                managementSystem.AddStudent(name, department);
                                break;
                            case 2:
                                return;

                            default:
                                Console.WriteLine("Invalid option, please try again.");
                                break;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error managing student: {ex.Message}");
                        throw;
                    }

                }

            }
            static void ManageCourses(StudentCourseManagementSystem managementSystem)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("1, Add course");
                        Console.WriteLine("2, Go Back");
                        Console.Write("Enter your choice(1-2): ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Course code:");
                                string courseCode = Console.ReadLine();
                                Console.WriteLine("Enter student course title:");
                                string title = Console.ReadLine();
                                Console.WriteLine("Enter student course unit:");
                                int unit = int.Parse(Console.ReadLine());
                                managementSystem.AddCourse(courseCode, title, unit);
                                break;
                            case 2:
                                return;

                            default:
                                Console.WriteLine("Invalid option, please try again.");
                                break;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error managing student: {ex.Message}");
                        throw;
                    }

                }

            }
            static void EnrollStudentsInCourses(StudentCourseManagementSystem managementSystem)
            {

                try
                {
                 
                   
                    
                     managementSystem.DisplayCourse();
                    Console.Write("Enter course code:");
                    string courseCode = Console.ReadLine();
                    Console.Write("Enter student matric to enroll in course:");
                    string matric = Console.ReadLine();
                    managementSystem.EnrollStudentInCourse(matric, courseCode);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error enrolling student in course: {ex.Message}");
                    
                }



            }
            
             static void DisplayInformation(StudentCourseManagementSystem managementSystem)
                {
                    try
                    {
                          managementSystem.DisplayStudents();
                    }
                    catch (Exception ex)
                    {
                         Console.WriteLine($"Error displaying student information: {ex.Message}");
                        throw;
                    }
              
                }


        }


    }
}


