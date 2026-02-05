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
            // menu start

            Console.WriteLine("Welcome to Sudoku!");
            Console.WriteLine("1 - inizia");
            Console.WriteLine("2 - esci");
            Console.Write("Scegli un'opzione: ");
            string scelta = Console.ReadLine();


            if (scelta == "1")
            {
                Console.WriteLine("Inizio del gioco...");
            }
            else if (scelta == "2")
            {
                // Exit the application
                Console.WriteLine("Uscita dall'applicazione. Arrivederci!");
            }
            else
            {
                Console.WriteLine("Opzione non valida. Riprova.");
            }

            int riga;
            int colonna;
            int numero;


            while (true) 
            {
                Console.Write("Inserisci la riga (1-9): ");
                if (int.TryParse(Console.ReadLine(), out riga) && riga >= 1 && riga <= 9)
                    break;
                Console.WriteLine("valore non valido");
               
            }

            while (true)
            {
                Console.Write("inserisci la colonna (1-9): ");
                if (int.TryParse(Console.ReadLine(), out colonna) && colonna >= 1 && colonna <= 9)
                    break;
                Console.WriteLine("valore non valido");
            }

            while (true)
            {
                Console.Write("inserisci il numero (1-9): ");
                if (int.TryParse(Console.ReadLine(), out numero) && numero >= 1 && numero <= 9)
                    break;
                Console.WriteLine("valore non valido");
            }
            
        
        
        }



        }
    }

