using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bom;
using NUnit.Framework;

namespace BomTest
{
    [TestFixture]
    public class BomDroidTests
    {
        [Test]
        public void Sum_Is_Zero_When_No_Entries()
        {
            var bomDroid = new BomDroid();
            Assert.AreEqual(0, bomDroid.MethodToTest(new Collection<int>()));
        }

        [Test]
        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { 1, 2, 3 }, 6)]
        public void Sum_Is_Calculated_Correctly_When_Entries_Supplied(int[] data, int expected)
        {
            var bomDroid = new BomDroid();
            Assert.AreEqual(expected, bomDroid.MethodToTest(new Collection<int>(data)));
        }

        [Test]
        public void Sum_Is_Zero_When_Null_Collection()
        {
            var bomDroid = new BomDroid();
            Assert.AreEqual(0, bomDroid.MethodToTest(null));
        }
    }
}
