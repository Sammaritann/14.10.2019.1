using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoEnumerable.Adapter
{
   public  class ComparerAdapter<T> : IComparer<T>
    {
        Comparison<T> comparison;

    public ComparerAdapter(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }
        public int Compare(T x, T y)
        {
            return comparison(x, y);
        }
    }
}
