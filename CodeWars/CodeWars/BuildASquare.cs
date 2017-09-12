using System.Linq;

namespace CodeWars
{
  //http://www.codewars.com/kata/build-a-square/train/csharp
  public static class BuildASquare
  {
    public static string GenerateShape(int n) 
      => string.Join("\n", Enumerable.Repeat(new string('+', n), n));
  }
}