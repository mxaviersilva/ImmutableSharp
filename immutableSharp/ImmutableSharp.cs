using System;
using System.Linq;

namespace ImmutableSharp
{
    public static class ImmutableSharp
    {
        /// <summary>
        /// Iterates over an IEnumerable and apply a function to a copy of it
        /// </summary>
        /// <param name="functor">The IEnumerable to iterate</param>
        /// <param name="function">The fuction to apply to each item</param>
        /// <typeparam name="T">Must be IEnumerable</typeparam>
        /// <returns>Returns a modified copy of the original functor</returns>
        public static T[] Map<T>(this T[] functor, Func<T, T> function) => functor.Select(function).ToArray();
        public static T[] Filter<T>(this T[] functor, Func<T, bool> function) => functor.Where(function).ToArray();
    }
}