using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokHyllan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManger bookManger = new BookManger();
            /*List<Book> BooksList = new List<Book>(); */   // En lista som innehåller alla Böcker
            bool isrunning = true;  // Här deklarerar vi variabeln som styr vår huvudloop
            while (isrunning)
            {
                // Skriver ut huvudmenyn
                Console.WriteLine("\t Bibiloteket");
                Console.WriteLine("\t[1] Lägg till en ny bok");
                Console.WriteLine("\t[2] Visa alla böcker");
                Console.WriteLine("\t[3] Radera alla böcker");
                Console.WriteLine("\t[4] Söka efter en book");
                Console.WriteLine("\t[5] Avsluta");
                Console.Write("\n\tVälj: ");
                if (Int32.TryParse(Console.ReadLine(), out int menu)) // Tar in användarens menyval
                {
                    Console.WriteLine();
                    switch (menu)
                    {
                        case 1:
                            bookManger.AddNewBook();// kallar metod AddnewBook från Bookmanger klass
                            break;
                        case 2:
                           bookManger.Show();  // kallar metod Show från Bookmanger klass
                            break;
                        case 3:
                            bookManger.DeleteBooks();  // kallar DeleteBooks AddnewBook från Bookmanger klass
                            break;
                        case 4:
                            bookManger.SearchBook(); // kallar metod searchBook
                            break;
                        case 5:
                            isrunning = false; // avsltaProgramet
                            break;
                        default:
                            Console.WriteLine("\n\tSkriv en siffra (1-4)");
                            break;
                    }
                }
            }
        }
    }
}
