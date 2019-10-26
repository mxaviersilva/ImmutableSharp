using NUnit.Framework;

namespace ImmutableSharp.UnitTests.Services
{
    [TestFixture]
    public class ImmutableSharpTestFilter
    {
        [Test]
        public static void AssertFilterRespectsCondition()
        {
            var a = new int[] {0, 1, 2, 3, 4, 5, 6, 7};
            var b = a.Filter((x => x > 2));
            
            for (var i = 0; i < b.Length; i++)
            {
                Assert.True((b[i] > 2), "!(b[i] > 2)");
            }
        }
        
        
    }
}