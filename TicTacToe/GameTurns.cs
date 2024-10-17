using GameLogic;
using FieldOperation;
using System.Text;
using System.Data;
// new comment
namespace Gameturns
{
    public class Player
    {
        public static bool WinCheck(int[,] Fields, int CharacterSelector)
        {
            bool TestHorizontal = WinDetermination.HorizontalWin(Fields, CharacterSelector);
            bool TestVertical = WinDetermination.VerticalWin(Fields, CharacterSelector);
            bool TestDiagonal = WinDetermination.DiagonalWin(Fields, CharacterSelector);
            bool IsWon = TestDiagonal == true | TestHorizontal == true | TestVertical == true;

            return IsWon;
        }
        public static int[,] UserInput(int[,] Fields, int CharacterSelector)
        {
            bool FieldSelected = false;
            int[,] ChangedFields = Fields;

            while (FieldSelected == false)
            {
                try
                {
                    int UserInput = Convert.ToInt16(Console.ReadLine());
                
                    bool NotOccupied = Changer.OccupationTest(Fields, UserInput, CharacterSelector);
                    if (NotOccupied == true)
                    {
                        ChangedFields = Changer.FieldChanger(Fields, UserInput, CharacterSelector);
                        FieldSelected = true;
                    }
                }
                catch
                {
                    continue;
                }
            }
            return ChangedFields;
        }
    }
    public class GameAction
    {
        public static void FieldProjector(int[,] Fields)
        {
            try
            {
                Console.Clear();
            } 
            catch{}
            Projector.FieldProjection(Fields);
        }
        public static bool DrawCheck(int[,] Fields)
        {
            string[,] Decodedvalues = WinDetermination.Decoder(Fields);
            bool IsDraw = false;

            IsDraw = 
            (
                Decodedvalues[0,0] != "-" && Decodedvalues[0,1] != "-" && Decodedvalues[0,2] != "-" &&
                Decodedvalues[1,0] != "-" && Decodedvalues[1,1] != "-" && Decodedvalues[1,2] != "-" &&
                Decodedvalues[2,0] != "-" && Decodedvalues[2,1] != "-" && Decodedvalues[2,2] != "-"
            );

            return IsDraw;
        }
    }
}