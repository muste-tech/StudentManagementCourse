namespace Mustakim
{
    public class Student:Person
{
    public string _Id;
    public string Department { get; set; }
    public List<Course> EnrolledCourses { get; set; }

        public Student(string name, string department):base(name)
        {
          
            _Id = GenerateId();
            Department = department;
            EnrolledCourses = new List<Course>();
             
    }
        private string GenerateId()
        {
            string id = $"{new Random().Next(1000, 9999)}";
            return id;
     }
         public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"ID: {_Id}");
        Console.WriteLine($"Department: {Department}");
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

}

}