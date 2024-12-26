using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Example2
    {
        static List<int> num = new List<int>();
        public Example2()
        {
            num.Add(22);
            num.Add(55);
            num.Add(11);
            num.Add(22);
            num.Add(44);
            num.Add(33);
            num.Add(66);
        }

        public void EvenNum()
        {
            var evenNum = num.FindAll(x => x % 2 == 0);
            Console.WriteLine("Even: ");
            foreach (var x in evenNum)
            {
                Console.WriteLine(x);
            }
        }

        public void SortList()
        {
            var sorted = num.OrderBy(x => x);
            Console.WriteLine("Sorted List: ");
            foreach (var x in sorted)
            {
                Console.WriteLine(x);
            }
        }

        public void IfPresent()
        {
            bool check = num.Any(x => x == 22);
            if (check){
                Console.WriteLine("22 is Present!"); 
            }
            else{
                Console.WriteLine("22 is Not Present!"); 
            }
        }
        public void RemoveDuplicates()
        {
            var distinct = num.Distinct();
            Console.WriteLine("After Removing Duplicates: ");

            foreach(var x in distinct)
            {
                Console.WriteLine(x);
            }
        }
        public void FindFirstElement()
        {
            int firstOccurance = num.First(x => x == 22);
            Console.WriteLine(firstOccurance);
        }

        public void DefaultExpression()
        {
            Console.WriteLine(num.FirstOrDefault(x => x == 22));
        }
    }
}
