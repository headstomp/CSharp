using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();

            output.Add(new Person { FirstName = "Paul", LastName = "Kazmir", Birthday = Convert.ToDateTime("3/1/1980"), YearsExperience = 15 });
            output.Add(new Person { FirstName = "Joe", LastName = "Smith", Birthday = Convert.ToDateTime("2/14/1971"), YearsExperience = 20 });
            output.Add(new Person { FirstName = "Sue", LastName = "Storm", Birthday = Convert.ToDateTime("5/11/1986"), YearsExperience = 4 });
            output.Add(new Person { FirstName = "Sara", LastName = "Jones", Birthday = Convert.ToDateTime("8/3/1978"), YearsExperience = 7 });
            output.Add(new Person { FirstName = "Jamie", LastName = "Doe", Birthday = Convert.ToDateTime("2/4/1995"), YearsExperience = 12 });
            output.Add(new Person { FirstName = "Mary", LastName = "Smith", Birthday = Convert.ToDateTime("1/9/1983"), YearsExperience = 23 });

            return output;
        }
    }
}
