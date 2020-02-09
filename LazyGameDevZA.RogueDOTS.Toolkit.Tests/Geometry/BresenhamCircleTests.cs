﻿using System.Collections.Generic;
using LazyGameDevZA.RogueDOTS.Toolkit.Geometry;
using NUnit.Framework;
using static Unity.Mathematics.math;
using int2 = Unity.Mathematics.int2;

namespace LazyGameDevZA.RogueDOTS.Toolkit.Tests.Geometry
{
    public class BresenhamCircleTests
    {
        [Test]
        public void CircleTestRadius1()
        {
            var circle = new BresenhamCircle(int2.zero, 1);
            var enumerator = circle.GetEnumerator();
            var points = new List<int2>(4);

            while(enumerator.MoveNext())
            {
                points.Add(enumerator.Current);
            }

            CollectionAssert.AreEqual(points, new List<int2>
            {
                int2(1, 0),
                int2(0, 1),
                int2(-1, 0),
                int2(0, -1)
            });
        }

        [Test]
        public void CircleTestRadius3()
        {
            var circle = new BresenhamCircle(int2.zero, 3);
            var enumerator = circle.GetEnumerator();
            var points = new List<int2>(16);

            while(enumerator.MoveNext())
            {
                points.Add(enumerator.Current);
            }

            CollectionAssert.AreEqual(points, new List<int2>
            {
                int2(3, 0),
                int2(0, 3),
                int2(-3, 0),
                int2(0, -3),
                int2(3, 1),
                int2(-1, 3),
                int2(-3, -1),
                int2(1, -3),
                int2(2, 2),
                int2(-2, 2),
                int2(-2, -2),
                int2(2, -2),
                int2(1, 3),
                int2(-3, 1),
                int2(-1, -3),
                int2(3, -1)
            });
        }
    }
}
