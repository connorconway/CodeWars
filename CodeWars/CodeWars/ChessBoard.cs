using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{

	// https://www.codewars.com/kata/chess-fun-number-1-chess-board-cell-color/train/csharp
	public class ChessBoard
	{
		public static bool ChessBoardCellColor(string cell1, string cell2)
		{
			return (cell1[0] + cell1[1]) % 2 == (cell2[0] + cell2[1]) % 2;
		}
	}
}