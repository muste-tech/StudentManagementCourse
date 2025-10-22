namespace Mustakim
{
    public class Course
{
    public string CourseCode { get; set; }
    public string Title { get; set; }
    public int Unit { get; set; }
   

    public Course(string courseCode, string title, int unit) 
        {
            try
            {
                if (string.IsNullOrEmpty(courseCode) || string.IsNullOrEmpty(title))
                {
                    throw new ArgumentException("Course code and title can't be null or empty");
                }
                if (unit <= 0)
                {
                    throw new ArgumentException("unit can't be null or empty");
                }
                CourseCode = courseCode;
                Title = title;
                Unit = unit;
                  
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating course : {ex.Message}");
                throw;
            }

        }

        public  void DisplayInfo()
        {
         
            try
            {
                
                Console.WriteLine($" Course code: {CourseCode}");
                  Console.WriteLine($"Title: {Title} ");
                    Console.WriteLine($"Unit: {Unit} units");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error displaying course info : {ex.Message}");
                
            }
            
        
    }
}


}