using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokHyllan2
{
    internal class BookManger 
    {
        private List<Book> books = new List<Book>();   
        public  Book AddNewBook() //Metod skapar ny bok
        {
            Console.Write("\tTitel: ");
            string titel = Console.ReadLine(); // mottaget värde

            Console.Write("\n\tFörfattare: ");
            string author = Console.ReadLine(); //mottaget värde

            int releaseDate; //intiera int 
            while (true)// loopa till användaren skriva rätt year format
            {
                Console.Write("\n\tutgivningsår : ");   
                Int32.TryParse(Console.ReadLine(), out releaseDate); 
                if (releaseDate.ToString().Length == 4 && releaseDate is int) //checka om year format yyyy skrivas rätt
                {
                    break; // avsluta while
                }
                else
                {
                     warningMessage("Du måste skriva year format yyyy");
                    bool reWrit = true; // starta om från rad 20
                }
            }
            int type = BookTypeSubMenu();  //användaren väljer vilken typ för bok
            Book newBook; // instansiera ett nytt objekt
            switch (type)
            {
                case 1:
                    newBook = new Novel(titel, author, releaseDate); // sätta värde till objekt
                    books.Add(newBook);
                    return newBook;
                case 2:
                    newBook = new Magazin(titel, author, releaseDate); // sätta värde till objekt
                    books.Add(newBook);
                    return newBook;
                case 3:
                    newBook = new BlogBook(titel, author, releaseDate); // sätta värde till objekt
                    books.Add(newBook);
                    return newBook;
                default:
                    newBook = new Unknown(titel, author, releaseDate); // sätta värde till objekt
                    books.Add(newBook);
                    return newBook;
            }
            Console.ReadLine();
            Console.Clear();
        }
        public  int BookTypeSubMenu() //användaren väljer typ av boken
        {
            while (true)
            {
                Console.WriteLine("\n\t Välj nummer, [1] Roman, [2] Tidsskrift, [3] Bloggbok "); // val meny
                Console.Write("\n\t");
                if (Int32.TryParse(Console.ReadLine(), out int choice)) //undvika programkrasch samt tar värde
                {
                    if (choice > 0 && choice < 4) // checka att user skriver mellan 1-4
                    {
                        Console.WriteLine("\n\tLagrat\n");
                        Console.ReadLine();
                        Console.Clear();
                        return choice;
                    }
                    else
                    {
                       warningMessage("Du måste skriva en siffra(1 - 3"); // utskrivit meddelande
                    }
                }
            }
        }
        public  List<Book> Show() // visa alla nuvarande böcker
        {
            if (books.Count == 0) // checka om listan tomot
            {
               warningMessage("Bibloteket är tomot!");
                return null;
            }
            else
            {
                foreach (Book book in books)
                {
                    Console.WriteLine("\t" + book.ToString()); // Utskriva samtliga böcker
                }
                return books;
            }
            Console.ReadLine();
            Console.Clear();
        }
        public void DeleteBooks() //radera alla böcxker
        {
            books.Clear(); // gerneric metod som toma listan
            Console.WriteLine("Alaa böcker har raderats!");
            Console.ReadLine();
            Console.Clear();
        }
        public void SearchBook() // söka bok genom  titel
        {
            Console.WriteLine("Skriv Titel av Boken");
            string _titel=  Console.ReadLine(); // tar emot Titel från user
            foreach (Book book in books)
            {
                if (book.Titel==_titel) // kolla om det matshar en bok i listan
                {
                    Console.WriteLine(book.ToString()+"  "+  "Hitat!"); // skriva ut boken
                }
                else
                {
                    Console.WriteLine("Boken har inte hitats!");
                }
            }
        }

        public void warningMessage(string kontext)   // Metod som visar ett fel medelande till nvänadre                  
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\t * " + kontext + " *");
            Console.ResetColor();
            Console.WriteLine("\t * (Tryck ENTER för att fortsätta)");
            Console.ReadLine();
        }
    }
}
