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
            // menu start: visualizzazione scelte

            Console.WriteLine("Welcome to Sudoku!"); 
            Console.WriteLine("1 - Inizia"); 
            Console.WriteLine("2 - Esci");
            Console.Write("Scegli un'opzione: ");
            string scelta = Console.ReadLine(); //lettura della scelta dell'utente


            if (scelta == "1") //se la scelta dell'utente è 1 farà...
            {
                Console.WriteLine("Inizio del gioco..."); //inizio
            }
            else if (scelta == "2") //se la scelta dell'utente è 2 farà...
            {
                Console.WriteLine("Uscita dall'applicazione. Arrivederci!"); //uscita dal codice
            }
            else // se l'utente inserisce un valore diverso da 1 o 2 farà...
            {
                Console.WriteLine("Opzione non valida. Riprova."); //messaggio di errore
            }

            // definizione delle tre variabili riga, colonna e numero
            int riga;
            int colonna;
            int numero;

            //cicli per la richiesta dei tre valori
            while (true) 
            {
                Console.Write("Inserisci la riga (1-9): "); //richiesta della riga
                if (int.TryParse(Console.ReadLine(), out riga) && riga >= 1 && riga <= 9) //definizione che il valore dovrà essere tra 1 e 9
                    break;
                Console.WriteLine("Valore non valido"); //errore se il numero non è 1 o 9
               
            }
            //i seguenti cicli fanno le stesse cose ma per colonna e numero
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

            Console.ReadKey(); //pausa per vedere i risultati prima della chiusura del programma
        }

       

        }
    
    }

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
            Console.WriteLine("quadrato " + ControllaQuadrato(sudoku, 0, 0, 0));
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
                        if (conto > 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
