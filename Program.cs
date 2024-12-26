using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Program
    {
        static Example e = new Example();
        static Example2 e2 = new Example2();

        static void Main(string[] args)
        {
            //e2.EvenNum();
            //e2.SortList();
            //e2.IfPresent();
            //e2.RemoveDuplicates();
            //e2.FindFirstElement();
            e2.DefaultExpression();

            //e.ForEachExpression();
            //e.OrderByExpression();
            //e.SelectExpression();
            //e.WhereExpression();
            //e.CountExpression();
            //e.AnyExpression();
            //e.DistinctExpression();
            //e.FindAllExpression();
            //e.OrderByDescendingExpression();
            //e.ToListExpression();
        }
    }
}
