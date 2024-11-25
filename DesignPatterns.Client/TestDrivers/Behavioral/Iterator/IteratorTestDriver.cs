using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static SkiaSharp.SKPath;

namespace DesignPatterns.Console.TestDrivers.Behavioral.Iterator
{
    public static class IteratorTestDriver
    {
        public static void RunTest()
        {
            var list = new List<string> { "I", "am", "Gandalf", "the", "White", "and", "I", "come", "to", "you", "now", "at", "the", "turn", "of", "the", "tide" };
            // Create two separate iterators for iterating the list
            var iterator1 = list.GetEnumerator();
            var iterator2 = list.GetEnumerator();
            // Move to the first value in the list
            iterator1.MoveNext();
            iterator2.MoveNext();

            PrintIteratorCurrentValue(iterator1);
            PrintIteratorCurrentValue(iterator2);

            iterator1.MoveNext();
            iterator2.MoveNext();
            iterator2.MoveNext();
            iterator2.MoveNext();

            PrintIteratorCurrentValue(iterator1);
            PrintIteratorCurrentValue(iterator2);
        }

        private static void PrintIteratorCurrentValue(List<string>.Enumerator enumerator)
        {
            var variableName = GetVariableName(() => enumerator);
            System.Console.WriteLine($"{variableName} value: '{enumerator.Current}'");
        }

        private static string GetVariableName<T>(Expression<Func<T>> expr)
        {
            var body = (MemberExpression)expr.Body;
            return body.Member.Name;
        }
    }
}
