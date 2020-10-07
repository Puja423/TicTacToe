using System;

namespace TICtacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To TicTacToe Game!");
            Console.WriteLine("===============================");
            var tictactoeGames = new TicTactoe();
            tictactoeGames.Initializeboard();

            tictactoeGames.player = tictactoeGames.ChooseOption();
            tictactoeGames.computer= tictactoeGames.player == 'X' ? 'O': 'X';
            tictactoeGames.showboard();

        }
    }
}
