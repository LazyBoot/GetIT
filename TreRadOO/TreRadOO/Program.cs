using System;
using System.Threading;

namespace TreRadOO
{
    class Program
    {
        static void Main()
        {
            var boardModel = new BoardModel();
            while (true)
            {
				Console.Clear();
                BoardView.Show(boardModel);
                Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
                var position = Console.ReadLine();
                if (!boardModel.SetPlayer1(position)) continue;

                if (CheckWinner(boardModel)) break;

                Thread.Sleep(1000);
                boardModel.SetRandomPlayer2();

                if (CheckWinner(boardModel)) break;
            }
        }

        private static bool CheckWinner(BoardModel boardModel)
        {
            if (!Game.CheckWin(boardModel)) return false;

			Console.Clear();
            BoardView.Show(boardModel);
            Console.WriteLine();
            Console.WriteLine($"{Game.Winner} vant!");
            Console.WriteLine("Trykk R for restart, eller en annen knapp for å avslutte...");
            if (Console.ReadKey().Key == ConsoleKey.R)
                Main();
            return true;

        }
    }
}
