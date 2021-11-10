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

		static char[] board = new char[10];
		public static void Main(String[] args)
		{
			Console.WriteLine("welcome to Tic Tac Toi GAME");
			Board();                            //calling the method board in main method	
		}
		public static void Board()
		{
			// giving each array index value as empty initially
			for (int i = 1; i < 10; i++)
			{
				board[i] = ' ';	

				Console.ReadLine();



			}
		}	
	}
}
