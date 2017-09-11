using NUnit.Framework;

namespace CodeWars.Tests
{
  [TestFixture]
  public class BuildASquareTests
  {
    [Test]
    public void GenerateShape()
    {
      Assert.AreEqual("", BuildASquare.GenerateShape(0));
      Assert.AreEqual("+", BuildASquare.GenerateShape(1));
      Assert.AreEqual("++\n++", BuildASquare.GenerateShape(2));
      Assert.AreEqual("+++\n+++\n+++", BuildASquare.GenerateShape(3));
    }
  }
}