using System.Linq;
using System.Text;

namespace CodeWars
{
	// https://www.codewars.com/kata/playing-with-passphrases
	public static class PlayingWithPassphrases
	{
		public static string PlayPass(string s, int n)
		{
			var newPass = new StringBuilder();
			foreach (var current in s)
			{
				newPass.Append(current);
			}

			return new string(newPass.ToString().Reverse().ToArray());
		}
	}
}