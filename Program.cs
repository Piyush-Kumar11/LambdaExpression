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
        static void Main(string[] args)
        {
            e.ForEachExpression();
            e.OrderByExpression();
            e.SelectExpression();
            e.WhereExpression();
            e.CountExpression();
            e.AnyExpression();
            e.DistinctExpression();
            e.FindAllExpression();
            e.OrderByDescendingExpression();
            e.ToListExpression();
        }
    }
}
