namespace GameLogic
{
    public class WinDetermination
    {
        public static string[,] Decoder(int[,] Fields)
        {
            string[,] Character = {{"", "", ""}, {"", "", ""}, {"", "", ""}};

            for (int row = 0; row < 3; row++)
            {
                for(int column = 0; column < 3; column++)
                {
                    switch(Fields[row, column])
                    {
                        case 0:
                            Character[row, column] = "-";
                            break;
                        case 1:
                            Character[row, column] = "O";
                            break;
                        case 2:
                            Character[row, column] = "X";
                            break;
                    }
                }
            }
            return Character;
        }
        public static bool HorizontalWin(int[,] Fields, int CharacterSelector)
        {
            bool IsWon = false;
            string[] RowSymbols = {"", "", ""};
            string[,] DecodedValues = Decoder(Fields);

            RowSymbols[0] = DecodedValues[0,0] + DecodedValues[0,1] + DecodedValues[0,2];
            RowSymbols[1] = DecodedValues[1,0] + DecodedValues[1,1] + DecodedValues[1,2];
            RowSymbols[2] = DecodedValues[2,0] + DecodedValues[2,1] + DecodedValues[2,2];

            switch (CharacterSelector)
            {
                case 1:
                    IsWon = RowSymbols[0] == "OOO" | RowSymbols[1] == "OOO" | RowSymbols[2] == "OOO";
                    break;
                case 2:
                    IsWon = RowSymbols[0] == "XXX" | RowSymbols[1] == "XXX" | RowSymbols[2] == "XXX";
                    break;
            }

            return IsWon;
        }
        public static bool VerticalWin(int[,] Fields, int CharacterSelector)
        {
            bool IsWon = false;
            string[] ColumnSymbols = {"", "", ""};
            string[,] DecodedValues = Decoder(Fields);

            ColumnSymbols[0] = DecodedValues[0,0] + DecodedValues[1,0] + DecodedValues[2,0];
            ColumnSymbols[1] = DecodedValues[0,1] + DecodedValues[1,1] + DecodedValues[2,1];
            ColumnSymbols[2] = DecodedValues[0,2] + DecodedValues[1,2] + DecodedValues[2,2];

            switch (CharacterSelector)
            {
                case 1:
                    IsWon = ColumnSymbols[0] == "OOO" | ColumnSymbols[1] == "OOO" | ColumnSymbols[2] == "OOO";
                    break;
                case 2:
                    IsWon = ColumnSymbols[0] == "XXX" | ColumnSymbols[1] == "XXX" | ColumnSymbols[2] == "XXX";
                    break;
            }

            return IsWon;
        }
        public static bool DiagonalWin(int[,] Fields, int CharacterSelector)
        {
            bool IsWon = false;
            string[] DiagonalSymbols = {"", ""};
            string[,] DecodedValues = Decoder(Fields);

            DiagonalSymbols[0] = DecodedValues[0,0] + DecodedValues[1,1] + DecodedValues[2,2];
            DiagonalSymbols[1] = DecodedValues[0,2] + DecodedValues[1,1] + DecodedValues[2,0];


            switch (CharacterSelector)
            {
                case 1:
                    IsWon = DiagonalSymbols[0] == "OOO" | DiagonalSymbols[1] == "OOO";
                    break;
                case 2:
                    IsWon = DiagonalSymbols[0] == "XXX" | DiagonalSymbols[1] == "XXX";
                    break;
            }
            return IsWon;
        }
    }
}