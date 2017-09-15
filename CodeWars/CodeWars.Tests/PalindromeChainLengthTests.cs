using NUnit.Framework;

namespace CodeWars.Tests
{
  [TestFixture]
  public class PalindromeChainLengthTests
  {
    [TestCase(87, 4)]
    [TestCase(10, 1)]
    [TestCase(1, 0)]
    [TestCase(88, 0)]
    public void GivenAOutputShouldBeB(int n, int passes)
    {
      Assert.AreEqual(passes, PalindromeChainLength.palindromeChainLength(n));
    }
  }
}