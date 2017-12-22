using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{

	// https://www.codewars.com/kata/chess-fun-number-1-chess-board-cell-color/train/csharp
	public class ChessBoard
	{
		public static bool ChessBoardCellColor(string cell1, string cell2)
		{
			var oddList = new List<char> {'A', 'C', 'E', 'G'};
			var evenList = new List<char> {'B', 'D', 'F', 'H'};

			if (oddList.Contains(cell1[0]) && oddList.Contains(cell2[0]) || evenList.Contains(cell1[0]) && evenList.Contains(cell2[0]))
			{
				if (cell1[1] % 2 == 0 && cell2[1] % 2 == 0) return true;
				return cell1[1] % 2 != 0 && cell2[1] % 2 != 0;
			}

			if (evenList.Contains(cell1[0]) && oddList.Contains(cell2[0]))
			{
				if (cell1[1] % 2 == 0 && cell2[1] % 2 != 0) return true;
				return cell1[1] % 2 != 0 && cell2[1] % 2 == 0;
			}

			if (!oddList.Contains(cell1[0]) || !evenList.Contains(cell2[0])) return false;
			if (cell1[1] % 2 == 0 && cell2[1] % 2 != 0) return true;
			return cell1[1] % 2 != 0 && cell2[1] % 2 == 0;
		}
	}
}