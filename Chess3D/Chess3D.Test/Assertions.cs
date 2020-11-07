using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Chess3D.Test
{
    public class Assertions
    {
        public static void MovesCollectionContainsCollection(IEnumerable<IEnumerable<int>> one, IEnumerable<IEnumerable<int>> two)
        {
            foreach (var move in two)
            {
                Assert.True(one.Any(x=> x.SequenceEqual(move)));
            }
        }
    }
}