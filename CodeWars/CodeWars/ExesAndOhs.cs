using System.Linq;

namespace CodeWars
{
    //http://www.codewars.com/kata/exes-and-ohs/train/csharp
    public static class ExesAndOhs
    {
      public static bool Xo(string input)
      {
        var inputArray = input.ToArray();
        var xTotal = 0;
        var oTotal = 0;

        foreach (var i in inputArray)
        {
          if (char.ToUpperInvariant(i) == char.ToUpperInvariant('x')) xTotal += 1;
          if (char.ToUpperInvariant(i) == char.ToUpperInvariant('o')) oTotal += 1;
        }

        return xTotal == oTotal;
      }
  }
}
