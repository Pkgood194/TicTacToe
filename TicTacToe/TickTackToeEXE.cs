using System;
using Gameturns;
using FieldOperation;
using GameLogic;

class Game
{
    static void Main()
    {
        int[,] Fields = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}};
        bool IsWon = false;

        GameAction.FieldProjector(Fields);

        while (IsWon == false)
        {
            Fields = Player.UserInput(Fields, 1);

            GameAction.FieldProjector(Fields);
        
            IsWon = Player.WinCheck(Fields, 1);
            bool IsDraw = GameAction.DrawCheck(Fields);

            if (IsWon == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Player 1 won!");
                Console.ResetColor();
                break;
            }
            else if (IsDraw == true)
            {
                Console.WriteLine("Draw!");
                break;
            }
            
            Fields = Player.UserInput(Fields, 2);            

            GameAction.FieldProjector(Fields);    

            IsWon = Player.WinCheck(Fields, 2);
            IsDraw = GameAction.DrawCheck(Fields);

            if (IsWon == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Player 2 won!");
                Console.ResetColor();
                break;
            }
            else if (IsDraw == true)
            {
                Console.WriteLine("Draw!");
                break;
            }
            
            GameAction.FieldProjector(Fields);
              
        }
    }
}
