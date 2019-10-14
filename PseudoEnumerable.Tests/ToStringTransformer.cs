using System;
using System.Collections.Generic;
using System.Text;
using PseudoEnumerable.Interfaces;

namespace PseudoEnumerable.Tests
{
    class ToStringTransformer : ITransformer<int, string>
    {
        public string Transform(int item)
        {
            return item.ToString();
        }
    }
}
