using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tic_Toc_Toe_Game
{
	class Program
	{


		static void Main(string[] args)
		{
			// Main method
			Console.WriteLine("Welcome to The tic tac toe Game");
			TicTacToeGame game1 = new TicTacToeGame();
			game1.createGame();

			Console.WriteLine("Game Begins.\nPlease select your letter");
			game1.selectLetter();







		}
	}
}
