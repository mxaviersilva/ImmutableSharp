using System.Linq;
using NUnit.Framework;
using static ImmutableSharp.ImmutableSharp;

namespace ImmutableSharp.UnitTests.Services
{
    [TestFixture]
    public class ImmutableSharpTestMap
    {
        [Test]
        public void MapAssertImmutability()
        {
            var a = new int[] {0, 1, 2, 3, 4, 5, 6, 7};
            var b = a.Map((x => x + 5));

            Assert.IsFalse((a.SequenceEqual(b)), "a.SequenceEqual(b)");
        }

        [Test]
        public void MapAssertCopy()
        {
            var a = new int[] {0, 1, 2, 3, 4, 5, 6, 7};
            var b = a.Map((x => x));
            b[5] = -4;

            Assert.IsFalse((a[5].Equals(b[5])), "a.SequenceEqual(b)");
        }

        [Test]
        public void MapAssertFunction()
        {
            var a = new int[] {0, 1, 2, 3, 4, 5, 6, 7};
            var b = a.Map((x => x + 4));
            for (var i = 0; i < a.Length; i++)
            {
                Assert.True((a[i] + 4 == b[i]), "!(a[i] == b[i])");
            }
        }
    }
}