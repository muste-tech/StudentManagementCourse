namespace Mustakim
{
    public class Course
{
    public string CourseCode { get; set; }
    public string Title { get; set; }
    public int Unit { get; set; }

    public Course(string courseCode, string title, int unit)
    {
        CourseCode = courseCode;
        Title = title;
        Unit = unit;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{CourseCode} - {Title} ({Unit} units)");
    }
}


}