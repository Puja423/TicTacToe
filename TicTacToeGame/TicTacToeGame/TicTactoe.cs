﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace TICtacToeGame
{
    class TicTactoe
    {
        public char[] board { get; set; }
        public char  player{get; set;}
        public char computer { get; set; }

        public void Initializeboard()
        {
            board = new char[10];
            for ( int i = 1; i < 10; i++)
                board[i] = ' ';
        }
        public char ChooseOption()
        {
            Console.Write("Choose X or O: ");
            var input = Convert.ToChar(Console.ReadLine());
            return (input == 'X' || input == 'O') ? input : ChooseOption();

        }

    }
}
