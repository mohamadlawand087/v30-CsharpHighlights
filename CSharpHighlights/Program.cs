using System;

namespace CSharpHighlights
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car car1 = new Car("Toyota", "Black");
            var car2 = new Car("Honda", "White");
            Car car3 = new ("Nissan", "Red");

            Car[] cars = {
                new ("Toyota", "White"),
                new ("Nissan", "Black"),
                new ("Nissan", "White"),
                new ("Mercedes", "red"),
                new ("Jeep", "yellow"),
                new ("BMW", "Orange"),
                new ("Honda", "Green"),
            };

            // foreach(var c in cars)
            // {
            //     Console.WriteLine($"The car brand {c.brand} has a color of {c.color}");
            // }

            decimal CalculateTax(Car car, decimal salePrice) =>
                car switch
                {
                    {brand: "Toyota"} => salePrice * 0.02m,
                    {brand: "Nissan", color: "Black"} => salePrice * 0.03m,
                    {brand: "Nissan"} => salePrice * 0.021m,
                    {brand: "Honda"} => salePrice * 0.019m,
                    {brand: "BMW"} => salePrice * 0.023m,
                    {brand: "Jeep"} => salePrice * 0.024m,

                    _ => 0m
                };

            var tax = CalculateTax(cars[1], 8000);
            var blackNissanTax = CalculateTax(cars[2], 8000);

            Console.WriteLine($"The tax is {tax} for {cars[1].brand} - {cars[1].color}");
            Console.WriteLine($"The tax is {blackNissanTax} for {cars[2].brand} - {cars[2].color}");

            var emp = new Employee
            {
                FirstName = "Mohamad",
                LastName = "Lawand",
                Email = "mohamad@email.com"
            };

            emp.Email = "mohamad@yahoo.com";

            var emp2 = new EmployeeNew
            {
                FirstName = "Donald",
                LastName = "Duck",
                Email = "donald@email.com"
            };

            //emp2.Email = "sadasdas@dsa.com";

            // var emp = new Employee("Mohamad", "Lawand", "mohamad@email.com");
            // emp.Email = "mohamad@yahoo.com";

            Machine machine = new();
            machine.WorkHard();
            machine.TakeABreak();

            string RockPaperScissors(string player1, string player2) =>
                (player1, player2) switch
                {
                    // tuple literals
                    ("rock", "paper") => "Paper wins",
                    ("rock", "scissors") => "Rock wins",
                    ("paper", "rock") => "Paper wins",
                    ("paper", "scissors") => "Scissors wins",
                    ("scissors", "paper") => "Scissors wins",
                    ("scissors", "rock") => "Rock wins",
                    (_, _) => "it is a tie"
                };

            var result = RockPaperScissors("rock", "paper");

             var result2 = RockPaperScissors("paper", "scissors");

            Console.WriteLine($"The winner is {result}");
            Console.WriteLine($"The winner is {result2}");

        }    
    }

    record Car (string brand, string color);

   class Employee
   {
    //    public Employee(string fname, string lname, string email)
    //    {
    //        FirstName = fname;
    //        LastName = lname;
    //        Email = email;
    //    }

       public string FirstName { get; set; }
       public string LastName { get;  set;}
       public string Email { get; set; }
   }

   class EmployeeNew
   {
       public string FirstName { get; init; }
       public string LastName { get; init; }
       public string Email { get; init; }
   }

   interface IDoWork
   {
       void WorkHard();
       void TakeABreak() {
           // add default implementation
           Console.WriteLine("This method is not yet implemented");
           throw new NotImplementedException();
       }
   }

    class Machine : IDoWork
    {
        public void WorkHard()
        {
            Console.WriteLine("I am working hard.");
        }

        public void TakeABreak()
        {
            Console.WriteLine("I am taking a break");
        }
    }
}
