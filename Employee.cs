using System.Runtime.CompilerServices;

namespace Mustakim
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string post;
       
       public string Name
        {
            get { return name; }
            set { name = value; }
        }
       public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)

                    salary = value;
                else
                    throw new ArgumentException("Salary must be greater than Zero (0)");
                
               }
       }
       public string Post
        {
            get { return post; }
            set
            {
                if (value is null)
                    throw new ArgumentException("Choose among the given post");
                else
                    post = value;
          }
       }
        decimal newsalary;
        public decimal ChangeSalary( string post)
        {
            while (true)
            {
                if (post == "1")
                {
                  return 15000;
                    break;
                }
                else if (post == "2")
                {
                    return 20000;
                    break;
                }
                else if (post == "3")
                {
                    return 25000;
                    break;
                }
                return 0;
          }
        }
        public void DisplayInfo(string name,decimal salary)
        {
           
            
            Console.WriteLine($"The name of the employee is:{name} and the company will be giving him a total amount of: {salary} at the end of the month as his salary if there is deduction in the amount sorry that is what we could afford");
            

        }

        public Employee(string name, decimal salary, string post)
        {
            name = Name;
            salary = Salary;
            post = Post;
        }
   } 
}