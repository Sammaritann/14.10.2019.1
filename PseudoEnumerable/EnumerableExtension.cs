using System;
using System.Collections.Generic;
using PseudoEnumerable.Interfaces;

namespace PseudoEnumerable
{
    public static class EnumerableExtension
    {
        #region Implementation through interfaces

        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> source,
            IPredicate<TSource> predicate)
        {
            // Add implementation method Filter from class ArrayExtension (Homework Day 9. 03.10.2019 Tasks 1-2)
            throw new NotImplementedException();
        }

        public static IEnumerable<TResult> Transform<TSource, TResult>(this IEnumerable<TSource> source,
            ITransformer<TSource, TResult> transformer)
        {
            // Call EnumerableExtension.Transform with delegate
            throw new NotImplementedException();
        }

        public static IEnumerable<TSource> OrderAccordingTo<TSource>(this IEnumerable<TSource> source,
            IComparer<TSource> comparer)
        {
            // Add implementation method OrderAccordingTo from class ArrayExtension (Homework Day 9. 03.10.2019 Tasks 1-2)
            throw new NotImplementedException();
        }

        #endregion
        
        #region Implementation vs delegates

        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> source,
            Predicate<TSource> predicate)
        {
            // Call EnumerableExtension.Filter with interface
            throw new NotImplementedException();
        }

        public static IEnumerable<TResult> Transform<TSource, TResult>(this IEnumerable<TSource> source,
            Converter<TSource, TResult> transformer)
        {
            // Implementation logic vs delegate Converter here 
            throw new NotImplementedException();
        }

        public static IEnumerable<TSource> OrderAccordingTo<TSource>(this IEnumerable<TSource> source,
            Comparison<TSource> comparer)
        {
            // Call EnumerableExtension.OrderAccordingTo with interface
            throw new NotImplementedException();
        }

        #endregion
    }
}