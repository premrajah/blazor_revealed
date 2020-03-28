using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public static  class IEnumeratorExtensions
    {

        public static bool Any(this IEnumerable enumerable) => enumerable.GetEnumerator().MoveNext() == true;
    }
}
