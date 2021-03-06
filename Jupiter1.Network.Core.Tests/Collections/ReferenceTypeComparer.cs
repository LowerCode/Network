﻿using System.Collections;
using Jupiter1.Network.Core.Tests.Structure;

namespace Jupiter1.Network.Core.Tests.Collections
{
    internal sealed class ReferenceTypeComparer : IComparer
    {
        public int Compare(ReferenceType x, ReferenceType y)
        {
            if (x == null && y != null)
                return -1;
            if (x != null & y == null)
                return 1;
            if (x == null)
                return 0;

            if (string.CompareOrdinal(x.Name, y.Name) != 0)
                return string.CompareOrdinal(x.Name, y.Name);

            if (x.Age.CompareTo(y.Age) != 0)
                return x.Age.CompareTo(y.Age);

            return 0;
        }

        public int Compare(object x, object y)
        {
            return Compare(x as ReferenceType, y as ReferenceType);
        }
    }
}