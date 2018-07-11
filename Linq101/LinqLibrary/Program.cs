using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            people = people.OrderBy(x => x.LastName).ToList();
            people = people.OrderByDescending(x => x.LastName).ToList();
            people = people.OrderBy(x => x.LastName).ThenBy(x => x.YearsExperience).ToList();

            //people = people.Where(x => x.YearsExperience >= 15).ToList();
            //people = people.Where(x => x.YearsExperience >= 15 && x.Birthday.Month == 3).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString() }) Expereince: { person.YearsExperience }");
            }

            int yearsTotal = 0;

            yearsTotal = people.Sum(x => x.YearsExperience);
            //yearsTotal = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsExperience);

            Console.WriteLine($"The total years expereince is { yearsTotal }");
            Console.ReadLine();

        }
    }
}
