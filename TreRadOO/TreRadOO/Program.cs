using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TreRadOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardModel = new BoardModel();
            while (true)
            {
                Console.Clear();
                BoardView.Show(boardModel);
                Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
                var position = Console.ReadLine();
                if (!boardModel.SetCross(position)) continue;

                if (CheckWinner(boardModel)) break;

                Thread.Sleep(2000);
                boardModel.SetRandomCircle();

                if (CheckWinner(boardModel)) break;
            }
        }

        private static bool CheckWinner(BoardModel boardModel)
        {
            if (Game.CheckWin(boardModel))
            {
                Console.WriteLine();
                Console.WriteLine($"{Game.Winner} want!");
                return true;
            }

            return false;
        }
    }
}
