// See https://aka.ms/new-console-template for more information
using LinqLibrary;

Console.WriteLine("Hello, World!");
List<Person> people = ListManager.LoadSampleData();

//people = people.OrderBy(x => x.LastName).ToList();

//people = people.OrderByDescending(x => x.LastName).ThenBy(x => x.YearsExperience).ToList();

//people = people.Where(x => x.YearsExperience > 5).ToList();

people = people.Where(x => x.YearsExperience > 5 && x.Birthday.Month == 3).ToList();


int yearsTotal = 0;

//yearsTotal = people.Sum(x => x.YearsExperience);

yearsTotal = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsExperience);

Console.WriteLine($" The total years experience is {yearsTotal}");

foreach (var person in people)
{
    Console.WriteLine($" { person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString()})");
}

Console.ReadLine();