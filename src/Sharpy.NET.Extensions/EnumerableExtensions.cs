using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpyNet.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable is Array array)
                return array.Length == 0;

            return !enumerable.Any();
        }

        public static bool IsNotEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.IsEmpty();
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.IsNull() || enumerable.IsEmpty();
        }

        public static bool IsNotNullAndNotEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.IsNullOrEmpty();
        }

        public static int Size<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable is Array array)
                return array.Length;

            return enumerable.Count();
        }
    }
}
