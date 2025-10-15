namespace Mustakim
{
    public class Cat:Animal 
    {
        public string Sound;
        
        public override void AnimalSound(string sound)
        {
            base.AnimalSound(sound);
            Console.WriteLine($"Cat :{sound}");
        }
        public Cat(string sound)
        {
           Sound=sound;
        }

    }
}
