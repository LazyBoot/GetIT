namespace TilfeldigFirkant
{
    class ScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        //public char GetCharacter()
        //{
        //    var returnVal = ' ';
        //    if (Up)
        //    {
        //        if (Down)
        //        {
        //            if (Left)
        //                if (Right)
        //                    returnVal = '┼';
        //                else
        //                    returnVal = '┤';
        //            else if (Right)
        //                returnVal = '├';
        //            else
        //                returnVal = '│';
        //        }
        //        else if (Left)
        //        {
        //            if (Right)
        //                returnVal = '┴';
        //            else
        //                returnVal = '┘';
        //        }
        //        else if (Right)
        //        {
        //            returnVal = '└';
        //        }
        //    }
        //    else if (Down)
        //    {
        //        if (Left)
        //        {
        //            if (Right)
        //                returnVal = '┬';
        //            else
        //                returnVal = '┐';
        //        }
        //        else if (Right)
        //        {
        //            returnVal = '┌';
        //        }
        //    }
        //    else if (Right && Left)
        //    {
        //        returnVal = '─';
        //    }


        //    return returnVal;
        //}

        public char GetCharacter()
        {
            if (Up && Down && Left && Right) return '┼';
            if (Up && Down && Left && !Right) return '┤';
            if (Up && Down && !Left && Right) return '├';
            if (Up && Down && !Left && !Right) return '│';
            if (Up && !Down && Left && Right) return '┴';
            if (Up && !Down && Left && !Right) return '┘';
            if (Up && !Down && !Left && Right) return '└';
            if (Up && !Down && !Left && !Right) return '╵';

            if (!Up && Down && Left && Right) return '┬';
            if (!Up && Down && Left && !Right) return '┐';
            if (!Up && Down && !Left && Right) return '┌';
            if (!Up && Down && !Left && !Right) return '╷';
            if (!Up && !Down && Left && Right) return '─';
            if (!Up && !Down && Left && !Right) return '╴';
            if (!Up && !Down && !Left && Right) return '╶';

            return ' ';
        }

        public void AddHorizontal()
        {
            Left = true;
            Right = true;
        }

        public void AddVertical()
        {
            Up = true;
            Down = true;
        }

        public void AddLowerLeftCorner()
        {
            Up = true;
            Right = true;
        }

        public void AddUpperLeftCorner()
        {
            Down = true;
            Right = true;
        }

        public void AddUpperRightCorner()
        {
            Down = true;
            Left = true;
        }

        public void AddLowerRightCorner()
        {
            Up = true;
            Left = true;
        }
    }
}