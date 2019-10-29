using System;
using System.Collections.Generic;

namespace ImmutableSharp
{
    /// <summary>
    /// 
    /// </summary>
    public static class ImmutableSharp
    {
        /// <summary>
        /// Iterates over an IEnumerable and apply a function to a copy of it
        /// </summary>
        /// <param name="functor">The IEnumerable to iterate over`</param>
        /// <param name="function">The fuction to apply to each item</param>
        /// <typeparam name="T">Must be IEnumerable</typeparam>
        /// <returns>Returns a modified by the function copy of the original functor</returns>
        public static T[] Map<T>(this IEnumerable<T> functor, Func<T, T> function) 
        {
            // Create list to copy the mapped enumerable to
            var functorCopy = new List<T> ();

            // Apply the function to each item in enumerable
            foreach(var item in functor) 
                functorCopy.Add(function(item));
            
            // Return the copy as an array
            return functorCopy.ToArray();
        }

        /// <summary>
        /// Mapper that can return a different type than the functor's type
        /// </summary>
        /// <param name="functor"></param>
        /// <param name="function"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="I"></typeparam>
        /// <returns></returns>
        public static I[] MapCast<T, I>(this IEnumerable<T> functor, Func<T, I> function) 
        {
            // Create list to copy the mapped enumerable to
            var functorCopy = new List<I> ();

            // Apply the function to each item in enumerable
            foreach(var item in functor) 
                functorCopy.Add(function(item));
            
            // Return the copy as an array
            return functorCopy.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="functor"></param>
        /// <param name="function"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] Filter<T>(this T[] functor, Func<T, bool> function)
        {
            var functorCopy = new List<T> ();

            foreach(var item in functor)
                if (function(item))
                    functorCopy.Add(item);

            return functorCopy.ToArray();
        }
    }
}