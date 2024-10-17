using System.Runtime.CompilerServices;

namespace FieldOperation
{
    public class Projector
    {
        public static void FieldProjection(int[,] Fields)
        {
            string[,] Character = {{"","",""},{"","",""},{"","",""}};
            int WorkAround = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    switch (Fields[row, column])
                    {
                        case 0:
                            Console.Write(" [] ");
                            WorkAround++;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" O ");
                            WorkAround++;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" X ");
                            WorkAround++;
                            break;
                    }
                    Console.ResetColor();
                    if (WorkAround <= 2)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.Write("\n");
                WorkAround = 0;
            }
        }
    }
    public class Changer
    {
        public static int[,] FieldChanger(int[,] Fields, int SelectedField, int CharacterSelector)
        {
            switch(SelectedField)
            {
                case 1:
                    Fields[2, 0] = CharacterSelector;
                    break;
                case 2:
                    Fields[2, 1] = CharacterSelector;
                    break;
                case 3:
                    Fields[2, 2] = CharacterSelector;
                    break;
                case 4:
                    Fields[1, 0] = CharacterSelector;
                    break;
                case 5:
                    Fields[1, 1] = CharacterSelector;
                    break;
                case 6:
                    Fields[1, 2] = CharacterSelector;
                    break;
                case 7:
                    Fields[0, 0] = CharacterSelector;
                    break;
                case 8:
                    Fields[0, 1] = CharacterSelector;
                    break;
                case 9:
                    Fields[0, 2] = CharacterSelector;
                    break;
            }
            return Fields;
        }
        public static bool OccupationTest(int[,] Fields, int SelectedField, int CharacterSelector)
        {
            bool NotOccupied = false;

            switch(SelectedField)
            {
            case 1:
                NotOccupied = Fields[2, 0] == 0;
                break;
            case 2:
                NotOccupied = Fields[2, 1] == 0;
                break;
            case 3:
                NotOccupied = Fields[2, 2] == 0;
                break;
            case 4:
                NotOccupied = Fields[1, 0] == 0;
                break;
             case 5:
                NotOccupied = Fields[1, 1] == 0;
                break;
            case 6:
                NotOccupied = Fields[1, 2] == 0;
                break;
            case 7:
                NotOccupied = Fields[0, 0] == 0;
                break;
            case 8:
                NotOccupied = Fields[0, 1] == 0;
                break;
            case 9:
                NotOccupied = Fields[0, 2] == 0;
                break;
            }
            return NotOccupied;
        }
    }
}