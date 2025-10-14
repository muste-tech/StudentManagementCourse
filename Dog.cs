namespace Mustakim
{
    public class Dog:Animal
    {
        public string Sound1;
      public string sound1="";
        public override void AnimalSound(string sound)
        {
           base.AnimalSound(sound) ;
            sound1 = sound;
           Console.WriteLine($"Dog - {sound1}");
           
        }
        public Dog (string sound1)
        {
            Sound1=sound1;
        }
    }
}