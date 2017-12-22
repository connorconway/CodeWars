namespace CodeWars
{
  public static class PalindromeChainLength
  {
    //https://www.codewars.com/kata/palindrome-chain-length/train/csharp
    public static int palindromeChainLength(int n)
    {
      var passes = -1;
      while (n != 1)
      {
        n = n.IsPalindrome();
        passes += 1;
      }

      return passes == -1 ? 0 : passes;
    }

    private static int IsPalindrome(this int n)
    {
      return n == n.Reverse() ? 1 : n + n.Reverse();
    }


    private static int Reverse(this int n)
    {
      var result = 0;
      while (n > 0)
      {
        result = result * 10 + n % 10;
        n /= 10;
      }
      return result;
    }
  }
}
