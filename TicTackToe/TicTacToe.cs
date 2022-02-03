using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToe
    {
        static char[] Board = new char[10];
        public void CreateBoard()
        {
            for (int i = 1; i <= Board.Length; i++)
            {
                Board[i] = ' ';
            }
        }
        public static void ShowBoard()
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Console.WriteLine("  |   |  ");
            Console.WriteLine("{0} | {1} | {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("  |   |  ");
            Console.WriteLine("{0} | {1} | {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("  |   |  ");
            Console.WriteLine("{0} | {1} | {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("  |   |  ");
        }
    }
}
