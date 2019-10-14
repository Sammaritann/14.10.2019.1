using PseudoEnumerable.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PseudoEnumerable.Tests
{
    internal class OddPredicate : IPredicate<int>
    {
        public bool IsMatching(int item)
        {
            return Math.Abs(item) % 2 == 0 ? true : false;
        }
    }
}
