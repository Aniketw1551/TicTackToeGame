﻿using System;
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
            TicTacToe.CreateBoard();
            TicTacToe.ChooseLetter();
            Console.ReadLine(); 
        }
    }
}
