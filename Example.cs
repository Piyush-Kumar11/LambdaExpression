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
        public void ForEachExpression()
        {
            list.ForEach(p => Console.WriteLine(p));
            Console.WriteLine("==================");
        }

        public void OrderByExpression()
        {
            var person = list.OrderBy(p => p.Name);
            foreach (var p in person) Console.WriteLine(p);
            Console.WriteLine("==================");
        }

        public void WhereExpression()
        {
            var p1 = list.Where(p => p.Name.Equals("Piyush"));
            foreach (var p in p1) Console.WriteLine(p);
            Console.WriteLine("==================");
        }

        public void SelectExpression()
        {
            var names = list.Select(p => p.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("==================");
        }
        public void CountExpression()
        {
            int count = list.Count(p => p.Age < 25);
            Console.WriteLine($"Number of people under 25: {count}");
            Console.WriteLine("==================");
        }
        public void FindAllExpression()
        {
            var peopleAbove20 = list.FindAll(p => p.Age > 20);
            foreach (var p in peopleAbove20)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("==================");
        }

        public void OrderByDescendingExpression()
        {
            var sortedByAgeDescending = list.OrderByDescending(p => p.Age).ToList();
            foreach (var p in sortedByAgeDescending)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("==================");
        }

        public void ToListExpression()
        {
            var peopleStartingWithA = list.Where(p => p.Name.StartsWith("A")).ToList();
            foreach (var p in peopleStartingWithA)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("==================");
        }

        public void AnyExpression()
        {
            bool hasPeopleAbove25 = list.Any(p => p.Age > 25);
            Console.WriteLine(hasPeopleAbove25 ? "There are people above 25." : "No one is above 25.");
            Console.WriteLine("==================");
        }

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
