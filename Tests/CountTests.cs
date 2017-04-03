﻿using NUnit.Framework;
using JM.LinqFaster;
using System.Linq;
using System;
using static Tests.Test;

namespace Tests {
    [TestFixture]
    class CountTests {

        [Test]
        public void CountArray() {
            var a = intArray.CountF(onlyEvenInts);
            var b = intArray.Count(onlyEvenInts);

            Assert.That(a, Is.EqualTo(b));            
        }

        [Test]
        public void LongCountArray() {
            var a = intArray.LongCountF(onlyEvenInts);
            var b = intArray.LongCount(onlyEvenInts);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void CountList() {
            var a = intList.CountF(onlyEvenInts);
            var b = intList.Count(onlyEvenInts);

            Assert.That(a, Is.EqualTo(b));
        }
    }
}
