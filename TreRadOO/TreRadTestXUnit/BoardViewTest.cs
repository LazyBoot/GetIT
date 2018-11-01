using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TreRadOO;
using TreRadTestXUnit.TestData;
using Xunit;

namespace TreRadTestXUnit
{
	public class BoardViewTest
	{
		public class BoardViewShowTests : IDisposable
		{
			private StreamWriter _standardOut;
			private StringWriter _writer;
			private BoardModel _boardModel;

			public BoardViewShowTests()
			{
				_standardOut = new StreamWriter(Console.OpenStandardOutput());
				_standardOut.AutoFlush = true;

				_writer = new StringWriter();
				Console.SetOut(_writer);

				_boardModel = new BoardModel();
			}

			public void Dispose()
			{
				Console.SetOut(_standardOut);
				_writer.Close();
				_writer.Dispose();
			}

			[Fact]
			public void ShowTest()
			{

				BoardView.Show(_boardModel);
				var expected = "  a b c" + Environment.NewLine +
							   " ┌─────┐" + Environment.NewLine +
							   "1│     │" + Environment.NewLine +
							   "2│     │" + Environment.NewLine +
							   "3│     │" + Environment.NewLine +
							   " └─────┘" + Environment.NewLine;

				Assert.Equal(expected, _writer.ToString());
			}

			[Fact]
			public void ShowTest2()
			{
				_boardModel.SetRandomPlayer2();
				_boardModel.SetRandomPlayer2();
				_boardModel.SetRandomPlayer2();

				BoardView.Show(_boardModel);

				var expected = "  a b c" + Environment.NewLine +
							   " ┌─────┐" + Environment.NewLine +
							   $"1│{BoardView.GetSymbol(_boardModel, 0)} {BoardView.GetSymbol(_boardModel, 1)} {BoardView.GetSymbol(_boardModel, 2)}│" +
							   Environment.NewLine +
							   $"2│{BoardView.GetSymbol(_boardModel, 3)} {BoardView.GetSymbol(_boardModel, 4)} {BoardView.GetSymbol(_boardModel, 5)}│" +
							   Environment.NewLine +
							   $"3│{BoardView.GetSymbol(_boardModel, 6)} {BoardView.GetSymbol(_boardModel, 7)} {BoardView.GetSymbol(_boardModel, 8)}│" +
							   Environment.NewLine +
							   " └─────┘" + Environment.NewLine;

				Assert.Equal(expected, _writer.ToString());
			}

			[Theory]
			[MemberData(nameof(BoardViewTestData.ShowTestData), MemberType = typeof(BoardViewTestData))]
			public void ShowTest3(int cell0, int cell1, int cell2)
			{
				_boardModel.SetSymbol(cell0, CellOwner.Player1);
				_boardModel.SetSymbol(cell1, CellOwner.Player2);
				_boardModel.SetSymbol(cell2, CellOwner.Player1);

				BoardView.Show(_boardModel);

				var expected = "  a b c" + Environment.NewLine +
							   " ┌─────┐" + Environment.NewLine +
							   $"1│{BoardView.GetSymbol(_boardModel, 0)} {BoardView.GetSymbol(_boardModel, 1)} {BoardView.GetSymbol(_boardModel, 2)}│" +
							   Environment.NewLine +
							   $"2│{BoardView.GetSymbol(_boardModel, 3)} {BoardView.GetSymbol(_boardModel, 4)} {BoardView.GetSymbol(_boardModel, 5)}│" +
							   Environment.NewLine +
							   $"3│{BoardView.GetSymbol(_boardModel, 6)} {BoardView.GetSymbol(_boardModel, 7)} {BoardView.GetSymbol(_boardModel, 8)}│" +
							   Environment.NewLine +
							   " └─────┘" + Environment.NewLine;

				Assert.Equal(expected, _writer.ToString());
			}
		}

		[Theory]
		[MemberData(nameof(BoardViewTestData.GetSymbolTestData), MemberType = typeof(BoardViewTestData))]
		public void GetSymbolTest(int cell, CellOwner owner)
		{
			var bm = new BoardModel();
			bm.SetSymbol(cell, owner);
			var symbol = BoardView.GetSymbol(bm, cell);
			Assert.Equal(BoardView.PlayerSymbols[(int)owner], symbol);
		}
	}
}
