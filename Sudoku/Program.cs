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



        }
    }
}
