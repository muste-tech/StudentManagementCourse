namespace Mustakim
{
    public class Person
    {
        public string Name { get; set; }
        public string Matric { get; private set; }
        public Person(string name)
        {
            Name = name;
            Matric = GenerateMatric();
        }
        private string GenerateMatric()
        {
            string mat = $"{new Random().Next(1000, 9999)}";
            return mat;
        }
            public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Matric: {Matric}");
    }


    }
}