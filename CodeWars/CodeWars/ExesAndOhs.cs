using System.Linq;

namespace CodeWars
{
    //http://www.codewars.com/kata/exes-and-ohs/train/csharp
    public static class ExesAndOhs
    {
      public static bool Xo(string input) 
        => input.ToLower().Count(x => x == 'x') == input.ToLower().Count(o => o == 'o');
  }
}
