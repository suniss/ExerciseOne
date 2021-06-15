using System;

namespace ExerciseOne
{
   
    
    class Program
    {
        public static string Name;
        public static string LastName;
        public static string Salary;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to personal registation");
            Console.WriteLine("Add personal name");
            Name = Console.ReadLine();

            Console.WriteLine("Add personal LastName");
            LastName = Console.ReadLine();

            Console.WriteLine("Add personal Salary");
            Salary = Console.ReadLine();

            createPersonal(Name, LastName, Salary);
        }

        public static void createPersonal(string Name, string LastName, string Salary)
        {
            Console.WriteLine("hi" + "Name" + Name +  "Last Name" +  LastName + "Salary" + Salary);
            Console.WriteLine("Personal registered");
        }
    }
}
