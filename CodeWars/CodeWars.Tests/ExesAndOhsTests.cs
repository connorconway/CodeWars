using NUnit.Framework;

namespace CodeWars.Tests
{
  [TestFixture]
  public class ExesAndOhsTests
  {
    [Test]
    public void SameNumberOfXsAndOs()
    {
      Assert.AreEqual(true, ExesAndOhs.Xo("xo"));
      Assert.AreEqual(true, ExesAndOhs.Xo("xxOo"));
      Assert.AreEqual(true, ExesAndOhs.Xo("ttt"));

      Assert.AreEqual(false, ExesAndOhs.Xo("xxxm"));
      Assert.AreEqual(false, ExesAndOhs.Xo("Oo"));
      Assert.AreEqual(false, ExesAndOhs.Xo("ooom"));
    }
  }
}
