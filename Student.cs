namespace Mustakim
{
    public class Student
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string Department { get; set; }
    public List<Course> EnrolledCourses { get; set; }

    public Student(string name, string id, string department)
    {
        Name = name;
        Id = id;
        Department = department;
        EnrolledCourses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        try
        {
            if (EnrolledCourses.Contains(course))
            {
                throw new Exception("Student is already enrolled in this course.");
            }
            EnrolledCourses.Add(course);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}, Department: {Department}");
        Console.WriteLine("Enrolled Courses:");
        foreach (var course in EnrolledCourses)
        {
            Console.WriteLine($"{course.CourseCode} - {course.Title}");
        }
    }
}

}