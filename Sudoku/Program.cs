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
            // CREAZIONE GRIGLIA SUDOKU
            Cella[,] sudoku = new Cella[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j] = new Cella(0, true);
                    Console.Write(sudoku[i, j].contenuto + " ");
                }
                Console.WriteLine();
            }

            // menu start: visualizzazione scelte
            Console.WriteLine("\nWelcome to Sudoku!");
            Console.WriteLine("1 - Inizia");
            Console.WriteLine("2 - Esci");
            Console.Write("Scegli un'opzione: ");
            string scelta = Console.ReadLine();

            if (scelta == "1")
            {
                Console.WriteLine("Inizio del gioco...");
            }
            else if (scelta == "2")
            {
                Console.WriteLine("Uscita dall'applicazione. Arrivederci!");
                return;
            }
            else
            {
                Console.WriteLine("Opzione non valida. Riprova.");
                return;
            }

            // definizione delle tre variabili riga, colonna e numero
            int riga;
            int colonna;
            int numero;

            while (true)
            {
                Console.Write("Inserisci la riga (1-9): ");
                if (int.TryParse(Console.ReadLine(), out riga) && riga >= 1 && riga <= 9)
                    break;
                Console.WriteLine("Valore non valido");
            }

            while (true)
            {
                Console.Write("Inserisci la colonna (1-9): ");
                if (int.TryParse(Console.ReadLine(), out colonna) && colonna >= 1 && colonna <= 9)
                    break;
                Console.WriteLine("Valore non valido");
            }

            while (true)
            {
                Console.Write("Inserisci il numero (1-9): ");
                if (int.TryParse(Console.ReadLine(), out numero) && numero >= 1 && numero <= 9)
                    break;
                Console.WriteLine("Valore non valido");
            }

            Console.WriteLine("riga " + ControllaRiga(sudoku, 0, 0));
            Console.WriteLine("colonna " + ControllaColonna(sudoku, 0, 0));
            Console.WriteLine("quadrato " + ControllaQuadrato(sudoku, 0, 0, 0));

            Console.ReadKey();
        }

        static bool ControllaRiga(Cella[,] sudoku, int riga, int numero)
        {
            int conto = 0;
            for (int i = 0; i < 9; i++)
            {
                if (sudoku[riga, i].contenuto == numero)
                {
                    conto++;
                    if (conto > 1) return false;
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
                    if (conto > 1) return false;
                }
            }
            return true;
        }

        static bool ControllaQuadrato(Cella[,] sudoku, int riga, int colonna, int numero)
        {
            int conto = 0;
            int startRow = (riga / 3) * 3;
            int startCol = (colonna / 3) * 3;

            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (sudoku[i, j].contenuto == numero)
                    {
                        conto++;
                        if (conto > 1) return false;
                    }
                }
            }
            return true;
        }
    }
}