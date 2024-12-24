using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Example
    {
        private static List<Person> list = new List<Person>();

        public Example()
        {
            list.Add(new Person(101, "Piyush", 22));
            list.Add(new Person(102, "Ayush", 14));
            list.Add(new Person(103, "Karan", 30));
            list.Add(new Person(104, "Rohan", 28));
            list.Add(new Person(105, "Varun", 28));

        }

        //It will traverse on each object of Person object
        public void ForEachExpression()
        {
            list.ForEach(p => Console.WriteLine(p));
            Console.WriteLine("==================");
        }

        //It will sort the person by name in default Order(Ascending)
        public void OrderByExpression()
        {
            var person = list.OrderBy(p => p.Name);
            foreach (var p in person) Console.WriteLine(p);
            Console.WriteLine("==================");
        }

        //Where the condition meets it will store those objects only
        public void WhereExpression()
        {
            var p1 = list.Where(p => p.Name.Equals("Piyush"));
            foreach (var p in p1) Console.WriteLine(p);
            Console.WriteLine("==================");
        }

        //it will return only names from the person object
        public void SelectExpression()
        {
            var names = list.Select(p => p.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("==================");
        }

        //It will count the person whose age is above 25
        public void CountExpression()
        {
            int count = list.Count(p => p.Age < 25);
            Console.WriteLine($"Number of people under 25: {count}");
            Console.WriteLine("==================");
        }

        //it will return all those objects whose age>20
        public void FindAllExpression()
        {
            var peopleAbove20 = list.FindAll(p => p.Age > 20);
            foreach (var p in peopleAbove20)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("==================");
        }

        //It will sort the person by name in descending Order
        public void OrderByDescendingExpression()
        {
            var sortedByAgeDescending = list.OrderByDescending(p => p.Age).ToList();
            foreach (var p in sortedByAgeDescending)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("==================");
        }

        //adds those person to the list whose criteria matches
        public void ToListExpression()
        {
            var peopleStartingWithA = list.Where(p => p.Name.StartsWith("A")).ToList();
            foreach (var p in peopleStartingWithA)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("==================");
        }

        //It will check if any person whose age>25 is present or not
        public void AnyExpression()
        {
            bool hasPeopleAbove25 = list.Any(p => p.Age > 25);
            Console.WriteLine(hasPeopleAbove25 ? "There are people above 25." : "No one is above 25.");
            Console.WriteLine("==================");
        }

        //It will remove duplicates
        public void DistinctExpression()
        {
            var distinctAges = list.Select(p => p.Age).Distinct();
            foreach (var age in distinctAges)
            {
                Console.WriteLine($"Age: {age}");
            }
            Console.WriteLine("==================");
        }
    }
}
