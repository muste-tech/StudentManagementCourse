namespace Mustakim
{
    public class Student:Person
{
    public string _Id;
    public string Department { get; set; }
    public List<Course> EnrolledCourses { get; set; }

        public Student(string name, string department):base(name)
        {
            try
            {
                if (string.IsNullOrEmpty(department))
                {
                    throw new ArgumentException("Department cannot be null or empty");
                }
             _Id = GenerateId();
            Department = department;
            EnrolledCourses = new List<Course>();
          }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating student : {ex.Message}");
                throw;
            }       
             
    }
        private string GenerateId()
        {
            try
            {
                  string id = $"{new Random().Next(1000, 9999)}";
            return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating an Id : {ex.Message}");
                throw;
            }
          
     }
         public override void DisplayInfo()
    {
        try
        {
              base.DisplayInfo();
        Console.WriteLine($"ID: {_Id}");
        Console.WriteLine($"Department: {Department}");
        }
        catch (Exception ex)
        {
                Console.WriteLine($"Error diplaying student info: {ex.Message}");
            
        }
      
    }

   

}

}