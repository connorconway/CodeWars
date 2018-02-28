using NUnit.Framework;

namespace CodeWars.Tests
{
	[TestFixture]
	public class ChessBoardTests
	{
		[Test]
		public void BasicTests()
		{
			var kata = new ChessBoard();


			Assert.AreEqual(true, ChessBoard.ChessBoardCellColor("A1", "A3"));
			Assert.AreEqual(true, ChessBoard.ChessBoardCellColor("E2", "C4"));
			Assert.AreEqual(true, ChessBoard.ChessBoardCellColor("B5", "B9"));
			Assert.AreEqual(true, ChessBoard.ChessBoardCellColor("A5", "B8"));
			Assert.AreEqual(true, ChessBoard.ChessBoardCellColor("B8", "A5"));
			Assert.AreEqual(true, ChessBoard.ChessBoardCellColor("A1", "C3"));
			Assert.AreEqual(false, ChessBoard.ChessBoardCellColor("B9", "A5"));
			Assert.AreEqual(false, ChessBoard.ChessBoardCellColor("A1", "H3"));
			Assert.AreEqual(false, ChessBoard.ChessBoardCellColor("A1", "A2"));
		}
	}
}