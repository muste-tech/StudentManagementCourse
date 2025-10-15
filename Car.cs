namespace Mustakim
{
    public class Car:Vehicle
    {
        //   public int Seat { get; set; }
        //   public int Doors {get; set; }
        // public int Wheel { get; set; }
        //  public string Name { get; set; }

        //  public Car(string brand, string model, string name, bool accelerate, bool stop, bool start, int seat,int wheel, int year, int doors)
        //  :base(stop,start,accelerate,model, brand,year)
        //  {
        //     Seat=seat;
        //     Doors=doors;
        //     Wheel=wheel;
        //     Name=name;
        //  }
        //  public override void DisplayInfo()
        //  {
        //     base.DisplayInfo();
        //     Console.Write($" Seat: {Seat}");
        //      Console.Write($" Doors: {Doors}");
        //       Console.Write($" Wheel: {Wheel}");
        //        Console.Write($" Name: {Name}");
        //  }
        public override void StartEngine()
        {
           
      Console.WriteLine("Choose if car is to start or not");
      Console.WriteLine("1, Start ");
      Console.WriteLine("2, Don't Start ");
      Console.WriteLine("3, Not interested");
      Console.WriteLine();
      Console.Write("Choose from option 1-3 : ");
      int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Car start successfully");
                    break;
                case 2:
                    Console.WriteLine("Car start Unsuccessfully");
                    break;
                case 3:
                    return;
                default:
                    throw new ArgumentException("Invalid option please choose again;");
                   
      }

        }
    }
} 