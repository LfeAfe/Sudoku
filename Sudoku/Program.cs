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
            Console.WriteLine("1 - inizia"); 
            Console.WriteLine("2 - esci");
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
                Console.WriteLine("valore non valido"); //errore se il numero non è 1 o 9
               
            }
            //i seguenti cicli fanno le stesse cose ma per colonna e numero
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

