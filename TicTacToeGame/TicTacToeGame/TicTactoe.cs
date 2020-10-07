using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;

namespace TICtacToeGame
{
    class TicTactoe
    {
        public char[] board { get; set; }
        public char player { get; set; }
        public char computer { get; set; }

        public void Initializeboard()
        {
            board = new char[10];
            for (int i = 1; i < 10; i++)
                board[i] = ' ';
        }
        public void Toss()
        {
            Console.Write("who will play first");
            Random random = new Random();
            int randomnum = random.Next(0, 1);

            if (randomnum == 0)
            {
                Console.WriteLine("player will play first");

            }
            else
                Console.WriteLine("Computer will play first");
        }
        public char ChooseOption()
        {
            Console.Write("Choose X or O: ");
            var input = Convert.ToChar(Console.ReadLine());
            return (input == 'X' || input == 'O') ? input : ChooseOption();

        }
        public void showboard()
        {
            for (int i = 1; i < 10; i++)
            {
                if(i %3 ==0)
                {
                    Console.WriteLine("{0}\n" ,board[i]);
                    if(i!=9)
                        Console.WriteLine("---------------");
                }
                else
                {
                    Console.Write("{0} |"  ,board[i]);
                        
               
                }
            }

        }
        
        public void usermove()
        {
            
                Console.WriteLine("player want to choose position :" );
            var choose = Convert.ToInt32(Console.ReadLine());
            if(choose<0 || choose>9)
            {
                Console.WriteLine("Invalid Input");
                usermove();
            }
            else if(board[choose]!=' ')
            {
                Console.WriteLine("location is not empty");
                usermove();
            }
            else
            {
              
                board[choose] = player;
                showboard();
            }
            
        }
        public bool CheckMove(int choose)
        {
            if (board[choose] == ' ')
                return true;
            else
                return false;
            
        }
       
    } 
}
