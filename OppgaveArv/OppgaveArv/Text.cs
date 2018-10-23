using System;

namespace OppgaveArv
{
    class Text : Shape
    {
        private string _text;

        public Text(Random random, string text, int maxX, int maxY) : base(random)
        {
            _text = text;
            X = random.Next(0, maxX - _text.Length);
            Y = random.Next(0, maxY);
        }

        public override string GetCharacter(int row, int col)
        {
            if (row != Y || col < X || col > X + _text.Length - 1) return null;

            return _text.Substring(col - X, 1);
        }
    }
}