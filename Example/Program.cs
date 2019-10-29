using System;
using static ImmutableSharp.ImmutableSharp;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            // These examples show function chaining and immutability
            var a = new int[] {0, 1, 2, 3, 4, 5, 6, 7};
            var b = a.Map((x => x + 5));
            var c = a.Map((x => x));
            var d = a.Map((x => x + 5)).Filter((x => x > 10));
            var e = new List<int> (a);
            var f = e.Map((x => x * 100)).Filter((x => x > 200)).MapCast<int, string>((x => x.ToString()));
            Console.WriteLine("a [{0}] typeof a is {1}", string.Join(", ", a), a.GetType());
            Console.WriteLine("b [{0}] typeof b is {1}", string.Join(", ", b), b.GetType());
            Console.WriteLine("c [{0}] typeof c is {1}", string.Join(", ", c), c.GetType());
            Console.WriteLine("d [{0}] typeof d is {1}", string.Join(", ", d), d.GetType());
            Console.WriteLine("f [{0}] typeof f is {1}", string.Join(", ", f), f.GetType());
            Console.WriteLine("a' [{0}]", string.Join(", ", a));
            Console.WriteLine("a == c is {0}", arg0: (a.SequenceEqual(c)));
        }
    }
}