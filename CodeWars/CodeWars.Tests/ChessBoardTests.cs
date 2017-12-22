using NUnit.Framework;

namespace CodeWars.Tests
{
	public class ChessBoardTests
	{
		[Test]
		public void BasicTests()
		{
			var kata = new ChessBoard();


			Assert.AreEqual(true, kata.ChessBoardCellColor("A1", "A3"));
			Assert.AreEqual(true, kata.ChessBoardCellColor("E2", "C4"));
			Assert.AreEqual(true, kata.ChessBoardCellColor("B5", "B9"));
			Assert.AreEqual(true, kata.ChessBoardCellColor("A5", "B8"));
			Assert.AreEqual(true, kata.ChessBoardCellColor("B8", "A5"));
			Assert.AreEqual(true, kata.ChessBoardCellColor("A1", "C3"));
			Assert.AreEqual(false, kata.ChessBoardCellColor("B9", "A5"));
			Assert.AreEqual(false, kata.ChessBoardCellColor("A1", "H3"));
			Assert.AreEqual(false, kata.ChessBoardCellColor("A1", "A2"));
		}
	}
}