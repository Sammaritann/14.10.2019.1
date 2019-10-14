using PseudoEnumerable.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoEnumerable.Adapter
{
    class PredicateAdapter<T> : IPredicate<T>
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
