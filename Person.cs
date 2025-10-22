using System;
using System.Collections.Generic;
namespace Mustakim
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Matric { get; private set; }
        public Person(string name)
        {
         try 
         {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name is required");
            
            }
              Name = name;
            Matric = GenerateMatric();
         }
         catch( Exception ex)
         {
            Console.WriteLine($"Error creating person : {ex.Message}");
            throw;;
         }

         
        }
        private string GenerateMatric()
        {
            try
            {
                  string mat = $"{new Random().Next(1000, 9999)}";
            return mat;
            }
            catch (Exception ex)
            {
               Console.WriteLine($"Error generating matric :{ex.Message}")  ;
                throw;
            }
          
        }
            public virtual void DisplayInfo()
    { 
        try
        {
             Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Matric: {Matric}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error displaying person info: {ex.Message}");
            
        }
       
    }


    }
}