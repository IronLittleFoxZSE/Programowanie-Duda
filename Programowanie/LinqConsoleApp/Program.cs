

using LinqConsoleApp;
using System.Drawing;

var people = new List<Person>
    {
        new Person() { Id=1, FirstName="Anna",  LastName="Nowak",    Age=29, Gender=Gender.Female, City="Kielce", Salary=8200m,  Skills=["C#", "LINQ", "SQL"] },
        new() { Id=2, FirstName="Marek", LastName="Kowalski", Age=43, Gender=Gender.Male,   City="Warszawa", Salary=15000m, Skills=["Azure", "C#", "DevOps"] },
        new() { Id=3, FirstName="Ewa",   LastName="Wiśniewska",Age=35, Gender=Gender.Female, City="Kraków", Salary=9800m,  Skills=["JavaScript", "React"] },
        new() { Id=4, FirstName="Jan",   LastName="Zieliński", Age=43, Gender=Gender.Male,   City="Gdańsk", Salary=12000m, Skills=["C#", "SQL"] },
        new() { Id=5, FirstName="Ola",   LastName="Maj",       Age=26, Gender=Gender.Female, City="Kielce", Salary=7200m,  Skills=["Python", "ML"] },
        new() { Id=6, FirstName="Piotr", LastName="Lewandowski",Age=37,Gender=Gender.Male,   City="Warszawa", Salary=13400m, Skills=["C#", "LINQ", "Azure"] },
        new() { Id=7, FirstName="Iga",   LastName="Kowal",     Age=31, Gender=Gender.Female, City="Kraków", Salary=9900m,  Skills=["Go", "Kubernetes"] },
        new() { Id=8, FirstName="Tomek", LastName="Sikora",    Age=29, Gender=Gender.Male,   City="Kielce", Salary=8800m,  Skills=["C#", "MAUI", "Bluetooth"] },
    };

void Print<T>(string title, IEnumerable<T> data)
{
    Console.WriteLine($"\n=== {title} ===");
    foreach (var item in data)
        Console.WriteLine(item);
}

Print("Cała kolekcja", people);

//FILTRACJA
/*
select *
from people
where City = "Kielce"
*/

var fromKielce = people.Where(p => p.City == "Kielce");
Print("Osoby z Kielc (Where)", fromKielce);