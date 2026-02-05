using Sudoku.Classi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cella[,] sudoku = new Cella[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j] = new Cella(0, true);
                    

                }

                

            }

            sudoku[0,0] = new Cella(5, false);
            sudoku[0,1] = new Cella(3, false);
            sudoku[0,2] = new Cella(0, true);
            sudoku[0,3] = new Cella(0, true);
            sudoku[0,4] = new Cella(7, false);
            sudoku[0,5] = new Cella(0, true);
            sudoku[0,6] = new Cella(0, true);
            sudoku[0,7] = new Cella(0, true);
            sudoku[0,8] = new Cella(0, true);

            sudoku[1,0] = new Cella(6, false);
            sudoku[1,1] = new Cella(0, true);
            sudoku[1,2] = new Cella(0, true);
            sudoku[1,3] = new Cella(1, false);
            sudoku[1,4] = new Cella(9, false);
            sudoku[1,5] = new Cella(5, false);
            sudoku[1,6] = new Cella(0, true);
            sudoku[1,7] = new Cella(0, true);
            sudoku[1,8] = new Cella(0, true);

            sudoku[2,0] = new Cella(0, true);
            sudoku[2,1] = new Cella(9, false);
            sudoku[2,2] = new Cella(8, false);
            sudoku[2,3] = new Cella(0, true);
            sudoku[2,4] = new Cella(0, true);
            sudoku[2,5] = new Cella(0, true);
            sudoku[2,6] = new Cella(0, true);
            sudoku[2,7] = new Cella(6, false);
            sudoku[2,8] = new Cella(0, true);

            sudoku[3,0] = new Cella(8, false);
            sudoku[3,1] = new Cella(0, true);
            sudoku[3,2] = new Cella(0, true);
            sudoku[3,3] = new Cella(0, true);
            sudoku[3,4] = new Cella(6, false);
            sudoku[3,5] = new Cella(0, true);
            sudoku[3,6] = new Cella(0, true);
            sudoku[3,7] = new Cella(0, true);
            sudoku[3,8] = new Cella(3, false);


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(sudoku[i, j].contenuto + " ");


                }
                Console.WriteLine();


            }
        }
    }
}
