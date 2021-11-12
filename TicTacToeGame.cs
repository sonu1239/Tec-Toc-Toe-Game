using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Toc_Toe_Game
{
    class TicTacToeGame
    {
        public void createGame()
        {
            char[] space = new char[10];

            for (int i = 1; i < 10; i++)
            {
                space[i] = ' ';
            }
        }
        public void selectLetter()
        {
            string player1;
            string Player2;

            Console.WriteLine("Choose X or O for playing the game");
            player1 = Convert.ToString(Console.ReadLine()).ToUpper();

            if (player1 == "O")
            {
                Player2 = "X";
                Console.WriteLine("Computer : " + Player2);
            }
            else if (player1 == "X")
            {
                Player2 = "O";
                Console.WriteLine("Computer : " + Player2);
            }
            else
            {
                Console.WriteLine("you have to choose between X and O");
            }

        }
    }
}
