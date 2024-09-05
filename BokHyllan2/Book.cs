using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokHyllan2
{
    abstract class Book
    {
        public string Titel { get; set; }  //Här sparas varje Titel  skapas
        public string Aurthor { get; set; }  //Här sparas Author Titel  skapas
        public string Type { get; set; } //Här sparas varje Type   skapas
        public int releaseDate { get; set; }  //Här sparas varje releaseDate  skapas

        public Book(string _titel, string _author, int _releaseDate)
        {
            Titel = _titel;  // Mottaget Titel tilldelas till objektets Titel
            this.Aurthor = _author;  // Mottaget Author tilldelas till objektets Author
            releaseDate = _releaseDate; // Mottaget reelaseDate tilldelas till objektets ReleaseDAte
        }
        public override string ToString() //Metod som visar bok information 
        {
            return "\"" + Titel + "\" skriven av " + Aurthor + "\"" + "   utgivningsår  " + +releaseDate + ". (" + Type + ")";
        }
    }
}
