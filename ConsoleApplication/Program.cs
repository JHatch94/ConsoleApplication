using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Create variables and store information
            string name = "Jordan Hatch";
            string location = "Rexburg, ID";
            
            //3. Output the stored variables in strings using interpolation
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I live in {location}");
            
            //4. Print out current date but not time
            var currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString("MM/dd/yyyy"));
            
            //5. Number of days until Christmas
            DateTime christmas = new DateTime(currentDate.Year, 12, 25);
            DateTime today = DateTime.Now;
            double daysUntilChristmas = (christmas - today).TotalDays;
            Console.WriteLine($"Only {daysUntilChristmas} days until Christmas!");
            
            //6. 


            //7.
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
