using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTackToe
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTackToe program");
            TicTackToe ticTackToe = new TicTackToe();
            ticTackToe.Board();
        }
    }
}
