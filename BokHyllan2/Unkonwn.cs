using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokHyllan2
{
    internal class Unknown : Book  //arv från Book
    {
        public Unknown(string _titel, string _author, int _releaseDate) : base(_titel, _author, _releaseDate)
        {
            Titel = _titel;  // Mottaget Titel tilldelas till objektets Titel
            Aurthor = _author;  // Mottaget Author tilldelas till objektets Author
            releaseDate = _releaseDate;  // Mottaget releaseDate tilldelas till objektets releaseDate
        }
        public override string ToString() //Metod som visar bok information 
        {
            return "\"" + Titel + "\" skriven av " + Aurthor + "\"" + "   utgivningsår  " + +releaseDate + ". " + Type + "okänd book";
        }
    }
}
