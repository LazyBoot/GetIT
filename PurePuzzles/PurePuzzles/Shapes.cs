using System;

namespace PurePuzzles
{
    class Shapes
    {
        private const string MidSpace = "    ";
        private const string HashTag = "#";
        private const string Space = " ";

        public static void DrawShapes()
        {
            DrawTriangle();

            Console.WriteLine(Environment.NewLine);

            DrawDiamond();

            Console.WriteLine(Environment.NewLine);

            DrawCross();
        }


        public static void DrawDiamond()
        {
            for (int row = 1; row <= 4; row++)
            {
                for (int i = 0; i < 4 - row; i++)
                {
                    Console.Write(Space);
                }

                for (int col = 0; col < 4 - Math.Abs(4 - row); col++)
                {
                    Console.Write(HashTag + HashTag);
                }

                Console.Write(Environment.NewLine);
            }

            DrawTriangle();
        }

        public static void DrawTriangle()
        {
            for (int row = 0; row < 4; row++)
            {
                for (int i = 0; i < 4 - Math.Abs(4 - row); i++)
                {
                    Console.Write(Space);
                }

                for (int col = 0; col < 4 - row; col++)
                {
                    Console.Write(HashTag + HashTag);
                }

                Console.Write(Environment.NewLine);
            }
        }

        public static void DrawCross()
        {

            for (int row = 1; row <= 4; row++)
            {
                for (int i = 0; i < 4 - Math.Abs(4 - row) - 1; i++)
                {
                    Console.Write(Space);
                }

                for (int col = 0; col < 4 - Math.Abs(4 - row); col++)
                {
                    Console.Write(HashTag);
                }

                for (int i = 0; i < 4 - row; i++)
                {
                    Console.Write(MidSpace);
                }

                for (int col = 0; col < 4 - Math.Abs(4 - row); col++)
                {
                    Console.Write(HashTag);
                }

                Console.Write(Environment.NewLine);
            }

            for (int row = 0; row < 4; row++)
            {
                for (int i = 0; i < 4 - row - 1; i++)
                {
                    Console.Write(Space);
                }

                for (int col = 0; col < 4 - row; col++)
                {
                    Console.Write(HashTag);
                }

                for (int i = 0; i < row; i++)
                {
                    Console.Write(MidSpace);
                }

                for (int col = 0; col < 4 - row; col++)
                {
                    Console.Write(HashTag);
                }

                Console.Write(Environment.NewLine);
            }
        }
    }
}