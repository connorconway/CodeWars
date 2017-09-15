namespace CodeWars
{
  public static class PalindromeChainLength
  {
    //https://www.codewars.com/kata/palindrome-chain-length/train/csharp
    public static int palindromeChainLength(int n)
    {
      var passes = 0;
      var reverse = n.Reverse();
      while (n != reverse)
      {
        n = n+reverse;
        reverse = n.Reverse();
        passes += 1;
      }

      return passes;
    }


    private static int Reverse(this int n)
    {
      var left = n;
      var rev = 0;
      while (left > 0)
      {
        var r = left % 10;
        rev = rev * 10 + r;
        left = left / 10;
      }

      return rev;
    }
  }
}
