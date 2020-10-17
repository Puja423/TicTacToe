﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;

namespace TICtacToeGame
{
    class TicTacToeGame
    {
        char[] _board;
        char _userChoice;
        char _systemChoice;
        int currUserInput;
        bool _userWonToss;

        public TicTacToeGame()
        {
            _board = new char[10];
        }

        public char[] Board { get => _board; }
        public char UserChoice { get => _userChoice; }
        public char SystemChoice { get => _systemChoice; }
        public bool UserWonToss { get => _userWonToss; }

        public void StartGame()
        {
            for (int i = 1; i < 10; i++)
            {
                _board[i] = ' ';
            }
        }

        public void UsersChoice()
        {
            Console.Write("Enter your choice to play further\n 'X' or 'O' ? ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'X' || ch == 'O')
            {
                _userChoice = ch;
                if (ch == 'X')
                    _systemChoice = 'O';
                else
                    _systemChoice = 'X';
            }
            else
            {
                Console.WriteLine("Wrong Choice");
                UsersChoice();
            }
        }

        public void ShowBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(_board[i]);
                    Console.WriteLine("\n----------");
                }
                else
                {
                    Console.Write(_board[i] + " | ");
                }
            }
        }

        public void UserMove()
        {
            Console.WriteLine("Enter index (1-9) to mark your choice :");
            int userMove = Convert.ToInt32(Console.ReadLine());
            if (userMove > 0 && userMove < 10)
            {
                if (_board[userMove] == ' ')
                    currUserInput = userMove;
                else
                {
                    Console.WriteLine("The given Index isn't empty");
                    UserMove();
                }
            }
            else
            {
                Console.WriteLine("Index should be between 1 to 9");
                UserMove();
            }
        }

        public void MakeMove()
        {
            _board[currUserInput] = _userWonToss ? _userChoice : _systemChoice;
            ShowBoard();
        }

        public void TossToStartFirst()
        {
            Console.WriteLine("Choose Head / Tail to start first");
            string userChoice = Console.ReadLine().ToLower();
            string[] coin = new string[2] { "head", "tail" };
            Random toss = new Random();
            _userWonToss = (coin[toss.Next(0, 2)] == userChoice);
            if (_userWonToss)
                Console.WriteLine("You won the toss");
            else
                Console.WriteLine("You lose the toss");
        }
    }
}