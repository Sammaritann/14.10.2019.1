﻿using PseudoEnumerable.Interfaces;
using System;
using System.Collections.Generic;

namespace PseudoEnumerable
{
    public static class EnumerableExtension
    {
        #region Implementation through interfaces

        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> source,
            IPredicate<TSource> predicate)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"{nameof(source)} should not be null");
            }

            if (predicate is null)
            {
                throw new ArgumentNullException($"{nameof(predicate)} should not be null");
            }

            foreach (var item in source)
            {
                if (predicate.IsMatching(item))
                {
                    yield return item;
                }

            }

        }

        public static IEnumerable<TResult> Transform<TSource, TResult>(this IEnumerable<TSource> source,
            ITransformer<TSource, TResult> transformer)
        {
            return Transform(source, transformer.Transform);          
        }

        public static IEnumerable<TSource> OrderAccordingTo<TSource>(this IEnumerable<TSource> source,
            IComparer<TSource> comparer)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"{nameof(source)} should not be null");
            }

            if (comparer is null)
            {
                throw new ArgumentNullException($"{nameof(comparer)} should not be null");
            }
    
            List<TSource> tempList = new List<TSource>(source);
            tempList.Sort(comparer);
            
            return tempList;
        }

        #endregion

        #region Implementation vs delegates

        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> source,
            Predicate<TSource> predicate)
        {
           return  Filter(source, new PredicateAdapter<TSource>(predicate));
        }

        public static IEnumerable<TResult> Transform<TSource, TResult>(this IEnumerable<TSource> source,
            Converter<TSource, TResult> transformer)
        {
            if (transformer is null)
            {
                throw new ArgumentNullException($"{nameof(transformer)} should not be null");
            }

            foreach (var item in source)
            {
                yield return transformer(item);
            }

        }

        public static IEnumerable<TSource> OrderAccordingTo<TSource>(this IEnumerable<TSource> source,
            Comparison<TSource> comparer)
        {
          return OrderAccordingTo(source,Comparer<TSource>.Create(comparer));
        }

        #endregion
        private class PredicateAdapter<T> : IPredicate<T>
        {
            Predicate<T> predicate;

            public PredicateAdapter(Predicate<T> predicate)
            {
                this.predicate = predicate;
            }
            public bool IsMatching(T item)
            {
                return predicate(item);
            }
        }
    }
}