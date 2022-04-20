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

            output.Add(new Person { FirstName = "Tim", LastName="Corey", Birthday = Convert.ToDateTime("02/10/1970"), YearsExperience = 4});
            output.Add(new Person { FirstName = "Joe", LastName = "Smith", Birthday = Convert.ToDateTime("03/12/1970"), YearsExperience = 2 });
            output.Add(new Person { FirstName = "Sue", LastName = "Storm", Birthday = Convert.ToDateTime("01/3/1970"), YearsExperience = 1 });
            output.Add(new Person { FirstName = "Sara", LastName = "Jones", Birthday = Convert.ToDateTime("03/6/1970"), YearsExperience = 5 });
            output.Add(new Person { FirstName = "Jamie", LastName = "Doe", Birthday = Convert.ToDateTime("02/5/1970"), YearsExperience = 8 });
            output.Add(new Person { FirstName = "Mary", LastName = "Smith", Birthday = Convert.ToDateTime("01/11/1970"), YearsExperience = 2 });


            return output;
        }
    }
}
