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
            Cella[,] sudoku = new Cella[9,9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j] = new Cella(0, true);
                    Console.Write(sudoku[i, j].contenuto + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("riga " + ControllaRiga(sudoku, 0, 0));
            Console.WriteLine("colonna " + ControllaColonna(sudoku, 0, 0));
        }

        static bool ControllaRiga(Cella[,] sudoku, int riga, int numero)
        {
            int conto = 0;
            for (int i = 0; i < 9; i++)
            {
                if (sudoku[riga, i].contenuto == numero)
                {
                    conto++;
                    if (conto > 1)
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        static bool ControllaColonna(Cella[,] sudoku, int colonna, int numero)
        {
            int conto = 0;
            for (int i = 0; i < 9; i++)
            {
                if (sudoku[i, colonna].contenuto == numero)
                {
                    conto++;
                    if (conto > 1)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
    }
}
