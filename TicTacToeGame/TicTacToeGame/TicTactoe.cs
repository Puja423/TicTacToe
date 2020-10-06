using System;
using System.Collections.Generic;
using System.Text;

namespace TICtacToeGame
{
    class TicTactoe
    {
        public char[] board { get; set; }

        public void Initializeboard()
        {
            board = new char[10];
            for ( int i = 1; i < 10; i++)
                board[i] = ' ';
        }
    }
}
