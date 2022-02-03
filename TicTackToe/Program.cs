using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe program");
            TicTacToe ticTacToe = new TicTacToe();
            TicTacToe.choosePlayerLetter();
            TicTacToe.ShowBoard();
            Console.ReadLine(); 
        }
    }
}
