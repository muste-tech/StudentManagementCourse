using System.Dynamic;

namespace Mustakim
{
    public abstract class Vehicle
    {

        // public bool Stop { get; set; }
        // public bool Start { get; set; }
        // public bool Accelerate { get; set; }
        // public int Year { get; set; }
        // public string Model { get; set; }
        // public string Brand { get; set; }

        // public Vehicle(bool stop, bool start, bool accelerate, string model, string brand, int year)
        // {

        //     Stop = stop;
        //     Accelerate = accelerate;
        //     Start = start;
        //     Year = year;
        //     Model = model;
        //     Brand = brand;
        // }
        // public virtual void DisplayInfo()
        // {
        //     Console.WriteLine($"Here is the details for the vehicle");
        //     Console.Write($"Brand: {Brand}");
        //     Console.Write($" Model: {Model}");
        //     Console.Write($" Accelerate: {Accelerate}");
        //     Console.Write($" Stop: {Stop}");
        //     Console.Write($" Start: {Start}");
        //     Console.Write($" Year: {Year}");
        // }
        public abstract void StartEngine();

    }
}